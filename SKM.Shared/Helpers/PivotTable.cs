using SKM.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SKM.Shared.Helpers {
	public static class PivotTable {
		public static DataTable ToPivotTable<T, TColumn, TRow, TData>(this IEnumerable<T> source,Func<T, TColumn> columnSelector,Expression<Func<T, TRow>> rowSelector, Func<IEnumerable<T>, TData> dataSelector) {
			DataTable table = new DataTable();
			var rowName = ((MemberExpression)rowSelector.Body).Member.Name;
			table.Columns.Add(new DataColumn(rowName));
			var columns = source.Select(columnSelector).Distinct();

			foreach (var column in columns)
				table.Columns.Add(new DataColumn(column.ToString()));

				var rows = source.GroupBy(rowSelector.Compile())
					.Select(rowGroup => new {
						Key = rowGroup.Key,
						Values = columns.GroupJoin(
							rowGroup,
							c => c,
							r => columnSelector(r),
							(c, columnGroup) => dataSelector(columnGroup))
					}
				);

				foreach (var row in rows) {
					var dataRow = table.NewRow();
					var items = row.Values.Cast<object>().ToList();
					items.Insert(0, row.Key);
					dataRow.ItemArray = items.ToArray();
					table.Rows.Add(dataRow);
				}

			return table;
		}

		public static dynamic[] ToPivotArray<T, TColumn, TRow, TData>(this IEnumerable<T> source, Func<T, TColumn> columnSelector, Expression<Func<T, TRow>> rowSelector, Func<IEnumerable<T>, TData> dataSelector) {

			var arr = new List<object>();
			var cols = new List<string>();
			String rowName = ((MemberExpression)rowSelector.Body).Member.Name;
			var columns = source.Select(columnSelector).Distinct();

			cols = (new[] { rowName }).Concat(columns.Select(x => x.ToString())).ToList();


			var rows = source.GroupBy(rowSelector.Compile())
								  .Select(rowGroup => new {
									  Key = rowGroup.Key,
									  Values = columns.GroupJoin(
											 rowGroup,
											 c => c,
											 r => columnSelector(r),
											 (c, columnGroup) => dataSelector(columnGroup))
								  }).ToArray();


			foreach (var row in rows) {
				var items = row.Values.Cast<object>().ToList();
				items.Insert(0, row.Key);
				var obj = GetAnonymousObject(cols, items);
				arr.Add(obj);
			}
			return arr.ToArray();
		}
		private static dynamic GetAnonymousObject(IEnumerable<string> columns, IEnumerable<object> values) {
			IDictionary<string, object> eo = new ExpandoObject() as IDictionary<string, object>;
			int i;
			for (i = 0; i < columns.Count(); i++) {
				eo.Add(columns.ElementAt<string>(i), values.ElementAt<object>(i));
			}
			return eo;
		}

		public static List<T> DataTableToEntityList<T>(DataTable dt) {
			//Logging.Info("Converting datatable to entity list");

			foreach (DataColumn column in dt.Columns) {
				dt.Columns[column.ColumnName].ColumnName = column.ColumnName.Replace(" ", "").Replace("-", "").ToLower();
			}

			var list = new List<T>();
			var boolTypes = new List<Type>() { typeof(bool?), typeof(bool) };
			var boolValues = new List<string>() { "true", "yes", "1", "y" };
			var stringTypes = new List<Type>() { typeof(string) };
			var dateTypes = new List<Type>() { typeof(DateTime?), typeof(DateTime) };

			foreach (DataRow row in dt.Rows) {
				var EntityModel = (T)Activator.CreateInstance(typeof(T));
				foreach (var property in EntityModel.GetType().GetProperties()) {
					try {
						if (dt.Columns.Contains(property.Name.ToLower())) {
							var propValue = row[property.Name.ToLower()].ToString();

							object value = null;
							var memType = property.PropertyType;

							if (boolTypes.Contains(memType))
								value = boolValues.Contains(propValue.ToLower());
							else if (stringTypes.Contains(memType))
								value = string.IsNullOrWhiteSpace(propValue) ? null : propValue.Trim();
							else if (dateTypes.Contains(memType))
								value = string.IsNullOrWhiteSpace(propValue) ? (DateTime?)null : DateTime.Parse(propValue);

							EntityModel.GetType().GetProperty(property.Name).SetValue(EntityModel, value);
						}
					}
					catch (Exception ex) {
						//Logging.Error("Error with the property: " + property.Name);
						throw ex;
					}
				}
				list.Add(EntityModel);
			}
			return list;
		}

      public static async Task<List<LemburPivotDTO>> CreateLemburPivot(List<SuratPerintahLemburDTO> splDTOs) {
         // var dataLembur = await splService.GetByGroupAndDate(gr, stDate, enDate);
         //var pivotLembur = splDTOs.SelectMany(spl => spl.SPLDetailDTOs).GroupBy(hl => hl.SuratPerintahLemburId).Select(g => new {
         //   SPLDetailId = g.Key,
         //   Ke1 = g.Where(x => x.LemburKe == 1).Sum(x => x.NominalLembur),
         //   Ke2 = g.Where(x => x.LemburKe == 2).Sum(x => x.NominalLembur),
         //   Ke3 = g.Where(x => x.LemburKe == 3).Sum(x => x.NominalLembur),
         //   Ke4 = g.Where(x => x.LemburKe == 4).Sum(x => x.NominalLembur),
         //   Ke5 = g.Where(x => x.LemburKe == 5).Sum(x => x.NominalLembur),
         //   Ke6 = g.Where(x => x.LemburKe == 6).Sum(x => x.NominalLembur),
         //   Ke7 = g.Where(x => x.LemburKe == 7).Sum(x => x.NominalLembur),
         //   Ke8 = g.Where(x => x.LemburKe == 8).Sum(x => x.NominalLembur),
         //   TotalLembur = g.Sum(x => x.NominalLembur)
         //}).ToList();


         //var joinedPivotLembur = from l in splDTOs
         //                        join pl in pivotLembur on l.Id equals pl.SPLDetailId
         //                        select new {
         //                           GrupKerja = l.GroupName,
         //                           NIK = l.NIK,
         //                           Nama = l.EmployeeName,
         //                           Tanggal = l.OTDate,
         //                           JenisLembur = l.OTType,
         //                           Ke1 = pl.Ke1,
         //                           Ke2 = pl.Ke2,
         //                           Ke3 = pl.Ke3,
         //                           Ke4 = pl.Ke4,
         //                           Ke5 = pl.Ke5,
         //                           Ke6 = pl.Ke6,
         //                           Ke7 = pl.Ke7,
         //                           Ke8 = pl.Ke8,
         //                           ToTalLembur = pl.TotalLembur
         //                        };

         List<LemburPivotDTO> lemburPivotDTOS = new();
         //foreach (var jpl in joinedPivotLembur) {
            // Console.WriteLine($"Grup {jpl.GrupKerja} NIK:{jpl.NIK} Nama:{jpl.Nama} Tanggal:{jpl.Tanggal} Ke1:{jpl.Ke1} Ke2:{jpl.Ke2} Ke3:{jpl.Ke3} Ke4:{jpl.Ke4} Ke5:{jpl.Ke5} Ke6:{jpl.Ke6} Ke7:{jpl.Ke7} Ke8:{jpl.Ke8} TotalLembur:{jpl.ToTalLembur}");
            //lemburPivotDTOS.Add(new LemburPivotDTO {
            //   GrupKerja = jpl.GrupKerja,
            //   NIK = jpl.NIK,
            //   Nama = jpl.Nama,
            //   Tanggal = jpl.Tanggal.Value.Date,
            //   JenisLembur = jpl.JenisLembur,
            //   Ke1 = jpl.Ke1.Value,
            //   Ke2 = jpl.Ke2.Value,
            //   Ke3 = jpl.Ke3.Value,
            //   Ke4 = jpl.Ke4.Value,
            //   Ke5 = jpl.Ke5.Value,
            //   Ke6 = jpl.Ke6.Value,
            //   Ke7 = jpl.Ke7.Value,
            //   Ke8 = jpl.Ke8.Value,
            //   Total = jpl.ToTalLembur.Value
            //});
         //}

         return lemburPivotDTOS;
      }

      //public static Task CreateLemburPivot(IEnumerable<SuratPerintahLemburDTO> enumerable) {
      //   throw new NotImplementedException();
      //}
   }
}


	
