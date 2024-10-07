using JadwalKerjaSecurityAPI.Conversions;
using JadwalKerjaSecurityAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SKM.Shared.Dtos;
using SKM.Shared.Helpers;
using System.Data;
using System.Dynamic;
using System.Text.Json.Serialization;

namespace JadwalKerjaSecurityAPI.Controllers {
	[Route("api/[controller]")]
	[ApiController]
	public class JadwalKerjaSecurityController : ControllerBase {
		private readonly IJadwalKerjaSecurityService jksService;

		public JadwalKerjaSecurityController(IJadwalKerjaSecurityService jksService) {
			this.jksService = jksService;
		}

		[HttpGet]
		public async Task<ActionResult<List<JadwalKerjaSecurityDTO>>> Get() {
			try {
				var jadwal = await jksService.GetJadwalKerjaSecuritiesAsync();
				if(jadwal == null) {
					return NoContent();
				}
				//List<JadwalKerjaSecurityDTO> jadwalKerjaSecurityDTOs = (List<JadwalKerjaSecurityDTO>)jadwal.ConvertToDTO();
				//var jadwalKerjaSecurityFiltered = jadwalKerjaSecurityDTOs.ToPivotArray(
				//	 item => item.Tgl.Day,
				//	 item => item.Nama,
				//	 items => items.Any() ? items.First().Inisial_Shift : null);
				//string jsonData = JsonConvert.SerializeObject(jadwalKerjaSecurityFiltered, new KeyValuePairConverter());

				//List<Jadwal> jadwals = PivotTable.DataTableToEntityList<Jadwal>(jadwalKerjaSecurityFiltered);
				//foreach(ExpandoObject jd in jadwalKerjaSecurityFiltered) {
				//	foreach(KeyValuePair<string, object> kvp in jd) {
				//		Console.WriteLine("{0}={1}", kvp.Key, kvp.Value);
				//	}

				//}
				//string jsonData = JsonConvert.SerializeObject(jadwalKerjaSecurityFiltered, new KeyValuePairConverter());
				//dynamic jadwalKerjaSecurityDataList = JsonConvert.DeserializeObject(jsonData);

				//List<Jadwal> jadwals = new();
				//Jadwal jd = new();
				//for (int x = 0; x <= jadwalKerjaSecurityFiltered.Rows.Count-1; x++) {
				//	jd.Nama = jadwalKerjaSecurityFiltered.Rows[x]["Nama"].ToString();
				//	for(int y = 1; y <= jadwalKerjaSecurityFiltered.Columns.Count-1; y++) {
				//		jd.Tanggal = new string[] { jadwalKerjaSecurityFiltered.Rows[x][y].ToString() };
				//	}
				//	jadwals.Add(jd);
				//}
				//         var lst = jadwalKerjaSecurityFiltered.AsEnumerable()
				//.Select(r => r.Table.Columns.Cast<DataColumn>()
				//.Select(c => new KeyValuePair<string, object>(c.ColumnName, r[c.Ordinal])).ToDictionary(z => z.Key, z => z.Value)).ToList();
				return Ok(jadwal.ConvertToDTO());
			}
			catch (Exception) {

				throw;
			}
		}

		[HttpGet("{month}/{year}")]
		public async Task<ActionResult<List<JadwalKerjaSecurityDTO>>> GetByMonthYear(int month, int year) {
			try {
				var jadwal = await jksService.GetJadwalSecuritiesByMonthYearAsync(month, year);
				if (jadwal == null) {
					return NoContent();
				}

				return Ok(jadwal.ConvertToDTO());
			}
			catch (Exception) {

				throw;
			}
		}

      [HttpGet]
		[Route("JKS/{startDate}/{endDate}")]
      public async Task<ActionResult<List<JadwalKerjaSecurityDTO>>> GetByDateRange(string startDate, string endDate) {
         try {
            var jadwal = await jksService.GetByDateRange(startDate, endDate);
            if (jadwal == null) {
               return NoContent();
            }

            return Ok(jadwal.ConvertToDTO());
         }
         catch (Exception) {

            throw;
         }
      }

      [HttpGet("Jadwal/{tgl}/{name}")]
		public async Task<ActionResult<JadwalKerjaSecurityDTO>> GetByDateName(string tgl, string name) {
			try {
				var jadwal = await jksService.GetByDateAndNameAsync(tgl, name);
				if (jadwal == null) {
					return NoContent();
				}

				return Ok(jadwal.ConvertToDTO());
			}
			catch (Exception) {

				throw;
			}
		}

		[HttpGet("NIKAndDate/{nik}/{strDate}")]
		public async Task<ActionResult<JadwalKerjaSecurityDTO>> GetByNIKAndDate(string nik, string  strDate) {
			try {
				DateTime date = DateConversions.StringToDate(strDate);
				var jadwal = await jksService.GetByNIKAndDate(nik, date);

				return Ok(jadwal?.ConvertToDTO());
				//if(jadwal is not null) {
				//	KehadiranDTO newAbsen = new() {
				//		GrupKerja = "SK/SECURITY",
				//		NIK = jadwal.NIK,
				//		Nama = jadwal.Nama,
				//		Tanggal = date.Date,
				//		JadwalMasuk = jadwal.JadwalMasuk,
				//		JamMasuk = DateTime.Now.TimeOfDay,
				//		JadwalPulang = jadwal.JadwalPulang
				//	};
				//	var kehadiran = await kehadiranService.Absen(newAbsen);
				//	return Ok(kehadiran?.ConvertToDTO());
				//}
				//else {
				//	return null;
				//}
				
			}
			catch (Exception) {

				throw;
			}
		}

		[HttpGet("JKS/{nik}/{tahun}/{bulan}")]
      public async Task<ActionResult<JadwalKerjaSecurityDTO>> GetByNIKAndMonthYear(string nik, int tahun, int bulan) {
         try {
				var jadwal = await jksService.GetByNIKAndMonth(nik, tahun, bulan);
            if (jadwal == null) {
               return NoContent();
            }

            return Ok(jadwal);
         }
         catch (Exception) {

            throw;
         }
      }

      [HttpPost]
		public async Task<ActionResult<JadwalKerjaSecurityDTO>> Post([FromBody] JadwalKerjaSecurityDTO jadwalKerjaSecurityDTO) {
			try {
				var jadwal = await jksService.AddJadwalKerjaSecurityAsync(jadwalKerjaSecurityDTO);
				if(jadwal == null) {
					return NoContent();
				}
				return Ok(jadwal.ConvertToDTO());
			}
			catch (Exception) {

				throw;
			}
		}

		[HttpPost("AddJadwalSecurityRange")]
		public async Task<ActionResult<JadwalKerjaKaryawanDTO>> PostRange([FromBody] IEnumerable<JadwalKerjaSecurityDTO> jadwalKerjaSecurityDTOs) {
			try {
				var jadwal = await jksService.AddRange(jadwalKerjaSecurityDTOs);
				return Ok(jadwal);
			}
			catch (Exception) {

				throw;
			}
		}

		[HttpPut]
		public async Task<ActionResult<JadwalKerjaSecurityDTO>> Put([FromBody] JadwalKerjaSecurityDTO jadwalKerjaSecurityDTO) {
			try {
				var jadwal = await jksService.UpdateAsync(jadwalKerjaSecurityDTO);
				if (jadwal == null) {
					return NoContent();
				}
				return Ok(jadwal.ConvertToDTO());
			}
			catch (Exception) {

				throw;
			}
		}
	}

	class Jadwal {
		public string? Nama { get; set; }
		public string? _1 { get; set; }
		public string? _2 { get; set; }
		public string? _3 { get; set; }
		public string? _4 { get; set; }

	}
}
