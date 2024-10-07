using ClosedXML.Excel;
using LupaAbsenAPI.Conversions;
using LupaAbsenAPI.Model;
using LupaAbsenAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SKM.Shared.Dtos;

namespace LupaAbsenAPI.Controllers {
   [Route("api/[controller]")]
   [ApiController]
   public class LupaAbsenController : ControllerBase {
      private readonly ICacheService cacheService;
      private readonly ILupaAbsenService lupaAbsenService;
      private static object _lock = new();

      public LupaAbsenController(ICacheService cacheService, ILupaAbsenService lupaAbsenService)
      {
         this.cacheService = cacheService;
         this.lupaAbsenService = lupaAbsenService;
      }

      [HttpGet]
      public IEnumerable<LupaAbsen> GetAllLupaAbse() {
         var cacheData = this.cacheService.GetData<IEnumerable<LupaAbsen>>("lupaabsen");
         if (cacheData != null) {
            //return StatusCode(StatusCodes.Status200OK, cacheData);
            return cacheData;
         }
         lock (_lock) {
            var expirationTime = DateTimeOffset.Now.AddHours(2.0);
            cacheData = this.lupaAbsenService.GetAll();            
            this.cacheService.SetData<IEnumerable<LupaAbsen>>("lupaabsen", cacheData, expirationTime);
            //return StatusCode(StatusCodes.Status200OK, cacheData);
            return cacheData;
         }
      }

		[HttpGet("GroupAndDate/{group}/{startDate}/{endDate}")]
		public async Task<ActionResult<List<LupaAbsenDTO>>> GetByGroupAndDateRange(string group, string? startDate, string? endDate) {
			try {
				var listLupaAbsen = await this.lupaAbsenService.GetByGroupAndDate(group, startDate, endDate);
				return Ok(listLupaAbsen.ConvertToDtO());
			}
			catch (Exception) {
				throw;
			}
		}

		[HttpPost]
      public async Task<ActionResult<LupaAbsenDTO>> AddLupaAbsenAsync([FromBody] LupaAbsenDTO lupaAbsenDTO) {
         var newLupaAbsen = await this.lupaAbsenService.AddLupaAbsen(lupaAbsenDTO);
         if(newLupaAbsen is null) {
            return NoContent();
         }
         this.cacheService.RemoveData("lupaabsen");
         return Ok(newLupaAbsen.ConvertToDTO());

      }

      [HttpGet("ExportToExcel/{group}/{startDate}/{endDate}")]
      public async Task<ActionResult<List<LupaAbsenDTO>>> ExportToExcel(string group, string? startDate, string? endDate) {
         try {
            var listLupaAbsen = await this.lupaAbsenService.GetByGroupAndDate(group, startDate, endDate);

            using (var wb = new XLWorkbook()) {
               var ws = wb.Worksheets.Add("Sheet1");

               ws.Cell(1, 1).Value = "Grup Kerja";
               ws.Cell(1, 2).Value = "Tanggal";
               ws.Cell(1, 3).Value = "NIK";
               ws.Cell(1, 4).Value = "Nama";
               ws.Cell(1, 5).Value = "Lupa Absen";
               ws.Cell(1, 6).Value = "Jam";

               for (int r = 1; r <= listLupaAbsen.Count - 1; r++) {
                  ws.Cell(r + 1, 1).Value = listLupaAbsen[r].GrupKerja;
                  ws.Cell(r + 1, 2).Value = listLupaAbsen[r].Tanggal.Value.Date.ToString("dd-MM-yyyy");
                  ws.Cell(r + 1, 3).Value = listLupaAbsen[r].NIK;
                  ws.Cell(r + 1, 4).Value = listLupaAbsen[r].NamaKaryawan;
                  ws.Cell(r + 1, 5).Value = listLupaAbsen[r].Absen;
                  ws.Cell(r + 1, 6).Value = listLupaAbsen[r].Jam;
               }
               // MemoryStream XLSStream = new();
               // wb.SaveAs(XLSStream);

               using (var stream = new MemoryStream()) {
                  wb.SaveAs(stream);
                  var content = stream.ToArray();
                  return File(
                     content,
                     "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                     "LupaAbsen.xlsx"
                  );
               }

            }
            //return Ok(listAbsenMasuk);
         }
         catch (Exception) {
            throw;
         }
      }
   }
}
