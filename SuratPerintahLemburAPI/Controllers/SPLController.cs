using AspNetCore.Reporting;
using ClosedXML.Excel;
using FastReport;
using FastReport.Data;
using FastReport.Utils;
using FastReport.Web;
using MassTransit;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SKM.Shared.Dtos;
using SKM.Shared.Helpers;
using SKM.Shared.Models;
using SuratperintahLemburAPI.Conversions;
using SuratperintahLemburAPI.Models;
using SuratperintahLemburAPI.Services;
using System.Data;
using System.Reflection;
using System.Text;
using System.Xml.Linq;

namespace SuratperintahLemburAPI.Controllers {
   [Route("api/[controller]")]
   [ApiController]
   public class SPLController : ControllerBase {
      private readonly ISuratPerintahLemburService _suratPerintahLemburService;
      private readonly ICacheService _cache;
      private readonly IBus _bus;
		private readonly IHostEnvironment hostEnvironment;
		private readonly IConfiguration configuration;
      private readonly IWebHostEnvironment webHostEnvironment;
      private static object _lock = new();

      public SPLController(ISuratPerintahLemburService suratPerintahLemburService, ICacheService cache, IBus bus, IHostEnvironment hostEnvironment, IConfiguration configuration, IWebHostEnvironment webHostEnvironment)
      {
         _suratPerintahLemburService = suratPerintahLemburService;
         _cache = cache;
         _bus = bus;
			this.hostEnvironment = hostEnvironment;
			this.configuration = configuration;
         this.webHostEnvironment = webHostEnvironment;
         System.Text.Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
      }

      [HttpGet]
      //[Authorize]
      //public async Task<ActionResult<IEnumerable<DepartmentDTO>>> DepartmentListAsync()
      public IEnumerable<SuratPerintahLemburDTO> GetSPLListAsync() {
         try {
            var cacheData = _cache.GetData<IEnumerable<SuratPerintahLemburDTO>>("spl");
            if (cacheData != null) {
               //return StatusCode(StatusCodes.Status200OK, cacheData);
               return cacheData;
            }
            lock (_lock) {
               var expirationTime = DateTimeOffset.Now.AddHours(2.0);
               cacheData = _suratPerintahLemburService.GetSPLListAsync();
               _cache.SetData("spl", cacheData, expirationTime);
            }

            //return StatusCode(StatusCodes.Status200OK, cacheData);
            return cacheData;
            //lock (_lock) {

         }
         catch (Exception) {
            //return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from database!");
            throw;
         }
      }

      [HttpGet("{id:int}")]
      //[Authorize]
      public ActionResult<IEnumerable<SuratPerintahLemburDTO>> GetSPLByIdAsync(int id) {
         try {
            SuratPerintahLembur spl;
            var cacheData = _cache.GetData<IEnumerable<SuratPerintahLembur>>("spl");
            if (cacheData != null) {
               spl = cacheData.Where(e => e.Id == id).FirstOrDefault();
               return StatusCode(StatusCodes.Status200OK, spl);
            }
            spl = (SuratPerintahLembur)_suratPerintahLemburService.GetSPLByIdAsync(id);
            return StatusCode(StatusCodes.Status200OK, spl);
         }
         catch (Exception) {
            return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from database");
         }
      }

      [HttpGet("{groupId}/{otDate}")]
      //[Authorize]
      public async Task<ActionResult<IEnumerable<SuratPerintahLemburDTO>>> GetSPLByGroupId_OTDateAsync(int groupId, int otDate) {
         try {
            IEnumerable<SuratPerintahLembur> spls;
            //var cacheData = _cache.GetData<IEnumerable<SuratPerintahLembur>>("spl");
            //if (cacheData != null) {
            //   spls = cacheData.Where(e => e.GroupId == groupId && e.OTDate == otDate).ToList();
            //   return StatusCode(StatusCodes.Status200OK, spls);
            //}
            spls = await _suratPerintahLemburService.GetSPLByGroupId_OTDate(groupId, otDate);
            return StatusCode(StatusCodes.Status200OK, spls);
         }
         catch (Exception) {
            return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from database");
         }
      }


      [HttpPost]
      //[Authorize(Roles = "Administrator")]
      public async Task<ActionResult<SuratPerintahLemburDTO>> AddSPL([FromBody] SuratPerintahLemburDTO splDTO) {
         try {
            var newSPL = await _suratPerintahLemburService.AddSPL(splDTO);
            //Uri uri = new("rabbitmq://localhost/spl");
            Uri uri = new("rabbitmq://localhost/exchange_name?bind=true&queue=spl");
            var endpoint = await _bus.GetSendEndpoint(uri);
            SuratPerintahLemburCreated SPLCreated = new SuratPerintahLemburCreated{
               GroupName = newSPL.GroupName,
                  DepartmentName = newSPL.DepartmentName,
                  EmployeeId = newSPL.EmployeeId.Value,
                  EmployeeName = newSPL.EmployeeName,
                  NIK = newSPL.NIK,
                  OTDate = (DateTime)newSPL.OTDate,
                  Upah = newSPL.Upah.Value,
            };
            
            //await endpoint.Send(listGajiCreated);
            await endpoint.Send(SPLCreated);
            if (newSPL == null) {
               return NoContent();
            }
            _cache.RemoveData("spl");
            return Ok(newSPL.ConvertToDTO());
         }
         catch (Exception) {

            throw;
         }
      }

      [HttpPost("AddSPLRange")]
      //[Authorize(Roles = "Administrator")]
      public async Task<ActionResult<SuratPerintahLemburDTO>> AddSPLRange([FromBody] IEnumerable<SuratPerintahLemburDTO> splDTOs) {
         try {
            var newSPL = await _suratPerintahLemburService.AddSPLRange(splDTOs);
            //Uri uri = new("rabbitmq://localhost/spl_range");
            Uri uri = new("rabbitmq://localhost/exchange_name?bind=true&queue=spl_range");
            var endpoint = await _bus.GetSendEndpoint(uri);
            List<SuratPerintahLemburCreated> listSPLCreated = new();
            foreach (var spl in splDTOs) {
               listSPLCreated.Add(new SuratPerintahLemburCreated {
                  GroupName = spl.GroupName,
                  DepartmentName = spl.DepartmentName,
                  EmployeeId = spl.EmployeeId.Value,
                  EmployeeName = spl.EmployeeName,
                  NIK = spl.NIK,
                  OTDate = spl.OTDate.Value.Date,
                  Upah = spl.Upah.Value,

               });
            };
            //await endpoint.Send(listGajiCreated);
            await endpoint.SendBatch(listSPLCreated);
            //if (newSPL == null) {
            //   return NoContent();
            //}
            _cache.RemoveData("spl");
            //return Ok(newSPL.ConvertToDTO());
            return NoContent();
         }
         catch (Exception) {

            throw;
         }
      }

      [HttpPut]
      //[Authorize(Roles = "Administrator")]
      public async Task<ActionResult<SuratPerintahLemburDTO>> UpdateSPLAsync(SuratPerintahLemburDTO splDTO) {
         SuratPerintahLembur spl = await _suratPerintahLemburService.UpdateSPLAsync(splDTO);
         //Uri uri = new Uri("rabbitmq://localhost/department");
         //var endPoint = await _bus.GetSendEndpoint(uri);
         //await endPoint.Send(new DepartmentCreated {
         //   DepartmentID = department.DepartmentID,
         //   DepartmentName = department.DepartmentName,
         //   DepartmentDescription = department.DepartmentDescription,
         //   CreatedBy = department.CreatedBy,
         //   CreatedAt = department.CreatedAt,
         //   IsActive = department.IsActive,
         //   UpdatedAt = department.UpdatedAt,
         //   UpdatedBy = department.UpdatedBy
         //});
         _cache.RemoveData("spl");
         //rabbitMqProducer.SendDepartmentMessage(department);
         return spl.ConvertToDTO();
      }

      [HttpDelete("{id}")]
      //[Authorize(Roles = "Administrator")]
      public async Task<ActionResult<SuratPerintahLemburDTO>> DeleteSPLAsync(int id) {
         //return departmentService.DeleteDepartmentAsync(id);
         SuratPerintahLembur spl = await _suratPerintahLemburService.DeleteSPLAsync(id);

         _cache.RemoveData("spl");
         return spl.ConvertToDTO();

      }

      [HttpGet("GroupAndDate/{group}/{startDate}/{endDate}")]
      public async Task<ActionResult<List<SuratPerintahLemburDTO>>> GetByGroupAndDate(string group, string startDate, string endDate) {
         try {
            var listSPL = await _suratPerintahLemburService.GetByGroupAndDate(group, startDate, endDate);
            return StatusCode(StatusCodes.Status200OK, listSPL.ConvertToDTO());

         }
         catch (Exception) {
            throw;
         }
      }

      [HttpGet("Report/All")]
      public IActionResult ReportAll() {
         WebReport webReport = new();
         MsSqlDataConnection mssqlConnection = new();
         mssqlConnection.ConnectionString = configuration.GetConnectionString("DefaultConnection");
         webReport.Report.Dictionary.Connections.Add(mssqlConnection);
         webReport.Report.Load(Path.Combine(hostEnvironment.ContentRootPath, "Reports", "lembur_coba.frx"));
         var lemburs = GetTable<SuratPerintahLemburDTO>(_suratPerintahLemburService.GetSPLListAsync(), "Lemburs");
         webReport.Report.RegisterData(lemburs, "Lemburs");

         //return View(webReport);
         return Ok(webReport);
      }



		//  public  IActionResult ReportAll() {
		//     string mime = "application/html";
		//     string webRootPath = this.hostingEnvironment.WebRootPath;
		//     string reportPath = (webRootPath + "/Reports/lembur_coba.frx");
		//     List<SuratPerintahLemburDTO> data = (List<SuratPerintahLemburDTO>)_suratPerintahLemburService.GetSPLListAsync();

		//     XDocument xmlDocument = new XDocument(
		//        new XDeclaration("1.0", "utf-8", "yes"),
		//        new XElement(
		//           "Lemburs",
		//           from d in data select new XElement("Grup", new XAttribute("ID", d.Id),
		//              new XElement("Grup", d.GroupName),
		//              new XElement("NIK", d.NIK),
		//		new XElement("Nama", d.EmployeeName),
		//		new XElement("Tanggal", d.OTDate),
		//		new XElement("OTTYpe", d.OTType),
		//		new XElement("OT1", d.OT1),
		//		new XElement("OT2", d.OT2),
		//		new XElement("OTTotal", d.OTTotal))
		//        )
		//     );
		//     xmlDocument.Save(@$"{webRootPath}\Reports\data_lembur.xml");
		//     string dataPath = webRootPath + "/Reports/data_lembur.xml";

		//     using(MemoryStream stream = new()) {
		//        try {
		//           using(DataSet dataSet = new()) {
		//              dataSet.ReadXml(dataPath);
		//              Config.WebMode = true;
		//              using(Report report = new()) {
		//                 report.Load(reportPath);
		//                 report.RegisterData(dataSet, "Lemburs");
		//                 report.Prepare();

		//                 HTMLExport html = new();
		//                 html.SinglePage = true;
		//                 html.Navigator = true;
		//                 report.Export(html, stream);
		//                 mime = "text/html";
		//              }
		//           }
		//	var file = string.Concat(Path.GetFileNameWithoutExtension(reportPath), ".", "html");
		//	return File(stream.ToArray(), mime);
		//}

		//        catch (Exception) {

		//           throw;
		//        }
		//     }
		//  }

		static DataTable GetTable<TEntity>(IEnumerable<TEntity> table, string name) where TEntity : class {
			var offset = 78;
			DataTable result = new DataTable(name);
			PropertyInfo[] infos = typeof(TEntity).GetProperties();
			foreach (PropertyInfo info in infos) {
				if (info.PropertyType.IsGenericType
				&& info.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>)) {
					result.Columns.Add(new DataColumn(info.Name, Nullable.GetUnderlyingType(info.PropertyType)));
				}
				else {
					result.Columns.Add(new DataColumn(info.Name, info.PropertyType));
				}
			}
			foreach (var el in table) {
				DataRow row = result.NewRow();
				foreach (PropertyInfo info in infos) {
					if (info.PropertyType.IsGenericType &&
						 info.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>)) {
						object t = info.GetValue(el);
						if (t == null) {
							t = Activator.CreateInstance(Nullable.GetUnderlyingType(info.PropertyType));
						}

						row[info.Name] = t;
					}
					else {
						if (info.PropertyType == typeof(byte[])) {
							//Fix for Image issue.
							var imageData = (byte[])info.GetValue(el);
							var bytes = new byte[imageData.Length - offset];
							Array.Copy(imageData, offset, bytes, 0, bytes.Length);
							row[info.Name] = bytes;
						}
						else {
							row[info.Name] = info.GetValue(el);
						}
					}
				}
				result.Rows.Add(row);
			}

			return result;
		}


      [HttpGet("ExportToExcel/{group}/{startDate}/{endDate}")]
      public async Task<ActionResult<List<LemburPivotDTO>>> ExportToExcel(string group, string? startDate, string? endDate) {
         try {
            List<SuratPerintahLembur> dataLembur = new();
            dataLembur = await this._suratPerintahLemburService.GetByGroupAndDate(group, startDate, endDate);
            var dataPivotLembur = await PivotTable.CreateLemburPivot((List<SuratPerintahLemburDTO>)dataLembur.ConvertToDTO());
            using (var wb = new XLWorkbook()) {
               var ws = wb.Worksheets.Add("Sheet1");

               ws.Range("A1:N1").Row(1).Merge();
               ws.Cell("A1").Value = $"Laporan Rekap Lembur Grup Kerja: {group} Periode: {DateConversions.StringToDate(startDate).ToString("dd-MM-yyyy")} s/d {DateConversions.StringToDate(endDate).ToString("d-MM-yyyy")}.";
               ws.Cell("A1").Style.Font.SetBold(true).Font.FontSize = 14;
               
               ws.Cell("A1").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
               ws.Cell("A1").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;

               ws.Cell("A2").Value = "Grup Kerja";
               ws.Cell("A2").Style.Font.SetBold(true);
               ws.Cell("A2").Style.Font.FontColor = XLColor.White;
               ws.Cell("A2").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
               ws.Cell("A2").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
               ws.Range("A2:A3").Column(1).Merge();
               ws.Range("A2:A3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
               ws.Range("A2:A3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
               ws.Range("A2:A3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
               ws.Range("A2:A3").Style.Border.RightBorder = XLBorderStyleValues.Thin;
               ws.Range("A2:A3").Style.Fill.BackgroundColor = XLColor.DarkGray;

               ws.Cell("B2").Value = "NIK";
               ws.Cell("B2").Style.Font.SetBold(true);
               ws.Cell("B2").Style.Font.FontColor = XLColor.White;
               ws.Cell("B2").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
               ws.Cell("B2").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
               ws.Range("B2:B3").Column(1).Merge();
               ws.Range("B2:B3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
               ws.Range("B2:B3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
               ws.Range("B2:B3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
               ws.Range("B2:B3").Style.Border.RightBorder = XLBorderStyleValues.Thin;
               ws.Range("B2:B3").Style.Fill.BackgroundColor = XLColor.DarkGray;

               ws.Cell("C2").Value = "Nama";
               ws.Cell("C2").Style.Font.SetBold(true);
               ws.Cell("C2").Style.Font.FontColor = XLColor.White;
               ws.Cell("C2").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
               ws.Cell("C2").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
               ws.Range("C2:C3").Column(1).Merge();
               ws.Range("C2:C3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
               ws.Range("C2:C3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
               ws.Range("C2:C3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
               ws.Range("C2:C3").Style.Border.RightBorder = XLBorderStyleValues.Thin;
               ws.Range("C2:C3").Style.Fill.BackgroundColor = XLColor.DarkGray;

               ws.Cell("D2").Value = "Tanggal";
               ws.Cell("D2").Style.Font.SetBold(true);
               ws.Cell("D2").Style.Font.FontColor = XLColor.White;
               ws.Cell("D2").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
               ws.Cell("D2").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
               ws.Range("D2:D3").Column(1).Merge();
               ws.Range("D2:D3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
               ws.Range("D2:D3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
               ws.Range("D2:D3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
               ws.Range("D2:D3").Style.Border.RightBorder = XLBorderStyleValues.Thin;
               ws.Range("D2:D3").Style.Fill.BackgroundColor = XLColor.DarkGray;

               ws.Cell("E2").Value = "Jenis Lembur";
               ws.Cell("E2").Style.Font.SetBold(true);
               ws.Cell("E2").Style.Font.FontColor = XLColor.White;
               ws.Cell("E2").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
               ws.Cell("E2").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
               ws.Range("E2:E3").Column(1).Merge();
               ws.Range("E2:E3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
               ws.Range("E2:E3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
               ws.Range("E2:E3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
               ws.Range("E2:E3").Style.Border.RightBorder = XLBorderStyleValues.Thin;
               ws.Range("E2:E3").Style.Fill.BackgroundColor = XLColor.DarkGray;

               ws.Cell("F2").Value = "Hitungan Lembur";
               ws.Cell("F2").Style.Font.SetBold(true);
               ws.Cell("F2").Style.Font.FontColor = XLColor.White;
               ws.Cell("F2").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
               ws.Cell("F2").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
               ws.Range("F2:N2").Row(1).Merge();
               ws.Range("F2:N2").Style.Border.TopBorder = XLBorderStyleValues.Thin;
               ws.Range("F2:N2").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
               ws.Range("F2:N2").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
               ws.Range("F2:N2").Style.Border.RightBorder = XLBorderStyleValues.Thin;
               ws.Range("F2:N2").Style.Fill.BackgroundColor = XLColor.DarkGray;

               ws.Cell("F3").Value = "Jam Ke-1";
               ws.Cell("F3").Style.Font.SetBold(true);
               ws.Cell("F3").Style.Font.FontColor = XLColor.White;
               ws.Cell("F3").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
               ws.Cell("F3").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
               ws.Cell("F3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
               ws.Range("F3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
               ws.Cell("F3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
               ws.Cell("F3").Style.Border.RightBorder = XLBorderStyleValues.Thin;
               ws.Cell("F3").Style.Fill.BackgroundColor = XLColor.DarkGray;

               ws.Cell("G3").Value = "Jam Ke-2";
               ws.Cell("G3").Style.Font.SetBold(true);
               ws.Cell("G3").Style.Font.FontColor = XLColor.White;
               ws.Cell("G3").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
               ws.Cell("G3").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
               ws.Cell("G3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
               ws.Cell("G3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
               ws.Cell("G3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
               ws.Cell("G3").Style.Border.RightBorder = XLBorderStyleValues.Thin;
               ws.Cell("G3").Style.Fill.BackgroundColor = XLColor.DarkGray;

               ws.Cell("H3").Value = "Jam Ke-3";
               ws.Cell("H3").Style.Font.SetBold(true);
               ws.Cell("H3").Style.Font.FontColor = XLColor.White;
               ws.Cell("H3").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
               ws.Cell("H3").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
               ws.Cell("H3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
               ws.Cell("H3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
               ws.Cell("H3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
               ws.Cell("H3").Style.Border.RightBorder = XLBorderStyleValues.Thin;
               ws.Cell("H3").Style.Fill.BackgroundColor = XLColor.DarkGray;

               ws.Cell("I3").Value = "Jam Ke-4";
               ws.Cell("I3").Style.Font.SetBold(true);
               ws.Cell("I3").Style.Font.FontColor = XLColor.White;
               ws.Cell("I3").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
               ws.Cell("I3").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
               ws.Cell("I3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
               ws.Cell("I3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
               ws.Cell("I3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
               ws.Cell("I3").Style.Border.RightBorder = XLBorderStyleValues.Thin;
               ws.Cell("I3").Style.Fill.BackgroundColor = XLColor.DarkGray;

               ws.Cell("J3").Value = "Jam Ke-5";
               ws.Cell("J3").Style.Font.SetBold(true);
               ws.Cell("J3").Style.Font.FontColor = XLColor.White;
               ws.Cell("J3").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
               ws.Cell("J3").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
               ws.Cell("J3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
               ws.Cell("J3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
               ws.Cell("J3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
               ws.Cell("J3").Style.Border.RightBorder = XLBorderStyleValues.Thin;
               ws.Cell("J3").Style.Fill.BackgroundColor = XLColor.DarkGray;

               ws.Cell("K3").Value = "Jam Ke-6";
               ws.Cell("K3").Style.Font.SetBold(true);
               ws.Cell("K3").Style.Font.FontColor = XLColor.White;
               ws.Cell("K3").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
               ws.Cell("K3").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
               ws.Cell("K3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
               ws.Cell("K3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
               ws.Cell("K3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
               ws.Cell("K3").Style.Border.RightBorder = XLBorderStyleValues.Thin;
               ws.Cell("K3").Style.Fill.BackgroundColor = XLColor.DarkGray;

               ws.Cell("L3").Value = "Jam Ke-7";
               ws.Cell("L3").Style.Font.SetBold(true);
               ws.Cell("L3").Style.Font.FontColor = XLColor.White;
               ws.Cell("L3").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
               ws.Cell("L3").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
               ws.Cell("L3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
               ws.Cell("L3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
               ws.Cell("L3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
               ws.Cell("L3").Style.Border.RightBorder = XLBorderStyleValues.Thin;
               ws.Cell("L3").Style.Fill.BackgroundColor = XLColor.DarkGray;

               ws.Cell("M3").Value = "Jam Ke-8";
               ws.Cell("M3").Style.Font.SetBold(true);
               ws.Cell("M3").Style.Font.FontColor = XLColor.White;
               ws.Cell("M3").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
               ws.Cell("M3").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
               ws.Cell("M3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
               ws.Cell("M3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
               ws.Cell("M3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
               ws.Cell("M3").Style.Border.RightBorder = XLBorderStyleValues.Thin;
               ws.Cell("M3").Style.Fill.BackgroundColor = XLColor.DarkGray;

               ws.Cell("N3").Value = "Total";
               ws.Cell("N3").Style.Font.SetBold(true);
               ws.Cell("N3").Style.Font.FontColor = XLColor.White;
               ws.Cell("N3").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;
               ws.Cell("N3").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
               ws.Cell("N3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
               ws.Cell("N3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
               ws.Cell("N3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
               ws.Cell("N3").Style.Border.RightBorder = XLBorderStyleValues.Thin;
               ws.Cell("N3").Style.Fill.BackgroundColor = XLColor.DarkGray;

               for (int r = 0; r <= dataPivotLembur.Count-1; r++) {
                  ws.Cell(r + 4, 1).Style.Border.TopBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 1).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 1).Style.Border.RightBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 1).Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 1).Value = dataPivotLembur[r].GrupKerja;

                  ws.Cell(r + 4, 2).Style.Border.TopBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 2).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 2).Style.Border.RightBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 2).Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 2).Value = dataPivotLembur[r].NIK;

                  ws.Cell(r + 4, 3).Style.Border.TopBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 3).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 3).Style.Border.RightBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 3).Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 3).Value = dataPivotLembur[r].Nama;

                  ws.Cell(r + 4, 4).Style.Border.TopBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 4).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 4).Style.Border.RightBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 4).Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 4).Value = dataPivotLembur[r].Tanggal.Value.Date.ToString("dd-MM-yyyy");

                  ws.Cell(r + 4, 5).Style.Border.TopBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 5).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 5).Style.Border.RightBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 5).Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 5).Value = dataPivotLembur[r].JenisLembur;

                  ws.Cell(r + 4, 6).Style.Border.TopBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 6).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 6).Style.Border.RightBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 6).Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 6).Value = dataPivotLembur[r].Ke1;

                  ws.Cell(r + 4, 7).Style.Border.TopBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 7).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 7).Style.Border.RightBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 7).Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 7).Value = dataPivotLembur[r].Ke2;

                  ws.Cell(r + 4, 8).Style.Border.TopBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 8).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 8).Style.Border.RightBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 8).Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 8).Value = dataPivotLembur[r].Ke3;

                  ws.Cell(r + 4, 9).Style.Border.TopBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 9).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 9).Style.Border.RightBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 9).Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 9).Value = dataPivotLembur[r].Ke4;

                  ws.Cell(r + 4, 10).Style.Border.TopBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 10).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 10).Style.Border.RightBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 10).Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 10).Value = dataPivotLembur[r].Ke5;

                  ws.Cell(r + 4, 11).Style.Border.TopBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 11).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 11).Style.Border.RightBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 11).Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 11).Value = dataPivotLembur[r].Ke6;

                  ws.Cell(r + 4, 12).Style.Border.TopBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 12).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 12).Style.Border.RightBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 12).Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 12).Value = dataPivotLembur[r].Ke7;

                  ws.Cell(r + 4, 13).Style.Border.TopBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 13).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 13).Style.Border.RightBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 13).Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 13).Value = dataPivotLembur[r].Ke8;

                  ws.Cell(r + 4, 14).Style.Border.TopBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 14).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 14).Style.Border.RightBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 14).Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                  ws.Cell(r + 4, 14).Value = dataPivotLembur[r].Total;
               }

               //MemoryStream XLSStream = new();
               //wb.SaveAs(XLSStream);

               //for (int r = 1; r <= listAbsenMasuk.Count - 1; r++) {
               //   ws.Cell(r + 1, 1).Value = listAbsenMasuk[r].GrupKerja;
               //   ws.Cell(r + 1, 2).Value = listAbsenMasuk[r].Tanggal.Value.Date.ToString("dd-MM-yyyy");
               //   ws.Cell(r + 1, 3).Value = listAbsenMasuk[r].NIK;
               //   ws.Cell(r + 1, 4).Value = listAbsenMasuk[r].Nama;
               //   ws.Cell(r + 1, 5).Value = listAbsenMasuk[r].JamMasuk;
               //   ws.Cell(r + 1, 6).Value = listAbsenMasuk[r].JamPulang;
               //   ws.Cell(r + 1, 7).Value = listAbsenMasuk[r].Terlambat;
               //}
               // MemoryStream XLSStream = new();
               // wb.SaveAs(XLSStream);

               using (var stream = new MemoryStream()) {
                  wb.SaveAs(stream);
                  var content = stream.ToArray();
                  return File(
                     content,
                     "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                     "RekapLembur.xlsx"
                  );
               }

            }
            //return Ok(listAbsenMasuk);
         }
         catch (Exception) {
            throw;
         }
      }

      [HttpGet("ReportRekapLembur/{group}/{startDate}/{endDate}")]
      public async Task<IActionResult> ReportRekapLembur(string group, string startDate, string endDate) {
         string mimetype = "";
         var path = $"{this.webHostEnvironment.WebRootPath}\\Reports\\RekapLembur.rdlc";
         Dictionary<string, string> parameters = new();

         var dataLembur = await this._suratPerintahLemburService.GetByGroupAndDate(group, startDate, endDate);
         var listLemburPivot = await PivotTable.CreateLemburPivot((List<SuratPerintahLemburDTO>)dataLembur.ConvertToDTO());

         var rekapLemburDT = new DataTable();
         rekapLemburDT.Columns.Add("GrupKerja");
         rekapLemburDT.Columns.Add("NIK");
         rekapLemburDT.Columns.Add("Nama");
         rekapLemburDT.Columns.Add("Tanggal");
         rekapLemburDT.Columns.Add("JenisLembur");
         rekapLemburDT.Columns.Add("Ke1");
         rekapLemburDT.Columns.Add("Ke2");
         rekapLemburDT.Columns.Add("Ke3");
         rekapLemburDT.Columns.Add("Ke4");
         rekapLemburDT.Columns.Add("Ke5");
         rekapLemburDT.Columns.Add("Ke6");
         rekapLemburDT.Columns.Add("Ke7");
         rekapLemburDT.Columns.Add("Ke8");
         rekapLemburDT.Columns.Add("TotalLembur");

         DataRow dr;
         foreach(var dl in listLemburPivot) {
            dr = rekapLemburDT.NewRow();
            dr["GrupKerja"] = dl.GrupKerja;
            dr["NIK"] = dl.NIK;
            dr["Nama"] = dl.Nama;
            dr["Tanggal"] = dl.Tanggal.Value.Date.ToString("dd-MM-yyyy");
            dr["JenisLembur"] = dl.JenisLembur;
            dr["Ke1"] = dl.Ke1;
            dr["Ke2"] = dl.Ke2;
            dr["Ke3"] = dl.Ke3;
            dr["Ke4"] = dl.Ke4;
            dr["Ke5"] = dl.Ke5;
            dr["Ke6"] = dl.Ke6;
            dr["Ke7"] = dl.Ke7;
            dr["Ke8"] = dl.Ke8;
            dr["TotalLembur"] = dl.Total;
            rekapLemburDT.Rows.Add(dr);
         }

         parameters.Add("param", $"Grup Kerja: {group} Periode: {DateConversions.StringToDate(startDate).ToString("dd-MM-yyyy")} s/d {DateConversions.StringToDate(endDate).ToString("dd-MM-yyyy")}");
         LocalReport localReport = new(path);
         
         localReport.AddDataSource("dsRekapLembur", rekapLemburDT);
         var result = localReport.Execute(RenderType.Pdf, 1, parameters, mimetype);
         return File(result.MainStream, "application/pdf");
      }

      [HttpGet("GetByDateRange/{startDate}/{endDate}")]
      public async Task<ActionResult<List<SuratPerintahLemburDTO>?>> GetByDateRange(string startDate, string endDate) {
         try {
            var listSPL = await _suratPerintahLemburService.GetByDateRange(startDate, endDate);
            return StatusCode(StatusCodes.Status200OK, listSPL);
         }
         catch (Exception) {
            throw;
         }
      }
   }
}
