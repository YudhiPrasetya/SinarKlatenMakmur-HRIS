using ClosedXML.Excel;
using KehadiranAPI.Conversions;
using KehadiranAPI.Services;
using MassTransit;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Newtonsoft.Json;
using SKM.Shared.Dtos;
using SKM.Shared.Models;

namespace KehadiranAPI.Controllers {
   [Route("api/[controller]")]
   [ApiController]
   public class KehadiranController : ControllerBase {
      private readonly IKehadiranServices kehadiranServices;
      private readonly IJadwalKehadiranService _jadwalKehadiranService;

      //private readonly IBus bus;

      public KehadiranController(IKehadiranServices kehadiranServices, IJadwalKehadiranService jadwalKehadiranService)
      {
         this.kehadiranServices = kehadiranServices;
         _jadwalKehadiranService = jadwalKehadiranService;
         //this.bus = bus;
      }

      [HttpGet]
      public async Task<ActionResult<List<KehadiranDTO>?>> Get() {
         try {
            var listHadir = await this.kehadiranServices.GetAllAsync();
            return Ok(listHadir.ConvertToDTO());
         }
         catch (Exception) {

            throw;
         }
      }
      [HttpPost("Ijin")]
      public async Task<ActionResult<int>> TambahIjin([FromBody] List<JadwalKehadiranDTO> jadwalKehadiranDTOs) {
         try {
            int Id = await this.kehadiranServices.TambahIjin(jadwalKehadiranDTOs.ConvertToModel());

            return Ok(Id);
         }
         catch (Exception) {

            throw;
         }
      }

      [HttpPost]
      [Route("Absen")]
      public async Task<ActionResult<KehadiranDTO?>> Absen([FromBody] KehadiranDTO kehadiranDTO) {
         try {
            var newHadir = await this.kehadiranServices.Absen(kehadiranDTO);

            //Uri uri = new("rabbitmq://localhost/kehadiran");

            //Uri uri = new("rabbitmq://localhost/exchange_name?bind=true&queue=kehadiran");
            //var endPoint = await this.bus.GetSendEndpoint(uri);
            //await endPoint.Send(new KehadiranCreated {
            //   Id = newHadir.Id,
            //   NIK = newHadir.NIK,
            //   Tanggal = newHadir.Tanggal
            //});

            //string host = "rabbitmq://localhost/exchange_name?bind=true&queue=kehadiran";
            //var instance = RabbitMqSingleton.GetInstance(host);
            //var endpoint = await instance.Bus.GetSendEndpoint(new Uri("queue:kehadiran"));
            //await endpoint.Send(new KehadiranCreated {
            //   Id = newHadir.Id,
            //   NIK = newHadir.NIK,
            //   Tanggal = newHadir.Tanggal
            //});
            //await instance.Bus.StopAsync();

            //if(newHadir != null) {
            //   var msg = JsonConvert.SerializeObject(newHadir);
            //   await kehadiranHub.Clients.All.sendToAllConnections(msg);

            //}
            return Ok(newHadir?.ConvertToDTO());
         }
         catch (Exception) {

            throw;
         }
      }

      //[HttpPut]
      //public async Task<ActionResult<KehadiranDTO>> UpdateAbsenMasuk(KehadiranDTO kehadiranDTO) {
      //   try {
      //      var hadir = await kehadiranServices.AddAbsenMasuk(kehadiranDTO);
      //      return Ok(hadir?.ConvertToDTO());
      //   }
      //   catch (Exception) {

      //      throw;
      //   }
      //}

		[HttpPut("UbahJam")]
		public async Task<ActionResult<KehadiranDTO>> UbahJam(KehadiranDTO kehadiranDTO) {
			try {
				var hadir = await kehadiranServices.UbahJam(kehadiranDTO);
				return Ok(hadir?.ConvertToDTO());
			}
			catch (Exception) {

				throw;
			}
		}

		[HttpGet("NIKAndDate/{nik}/{date}")]
      public async Task<ActionResult<KehadiranDTO?>> GetByNIKDate(string nik, string date) {
         DateTime dateNow = DateTime.Now.Date;
         try {
            var absenMasuk = await this.kehadiranServices.GetByNIKAndDate(nik, date);
            return Ok(absenMasuk?.ConvertToDTO());
         }
         catch (Exception) {

            throw;
         }
      }

      [HttpGet("DateRange/{startDate}/{endDate}")]
      public async Task<ActionResult<List<AbsenMasukDTO>>> GetByDateRange(string? startDate, string? endDate) {
         try {
            var listAbsenMasuk = await this.kehadiranServices.GetByRangeDate(startDate, endDate);
            return Ok(listAbsenMasuk);
         }catch(Exception) {
            throw;
         }
      }

      [HttpPut("AbsenPulang")]
      public async Task<ActionResult<KehadiranDTO>> UpdateAbsenPulang(KehadiranDTO kehadiranDTO) {
         try {
            var hadir = await this.kehadiranServices.AbsenPulang(kehadiranDTO);
            return Ok(hadir);
         }
         catch (Exception) {

            throw;
         }
      }

      [HttpGet("GroupAndDate/{group}/{startDate}/{endDate}")]
      public async Task<ActionResult<List<KehadiranDTO>>> GetByGroupAndDateRange(string group, string? startDate, string? endDate) {
         try {
            var listAbsenMasuk = await this.kehadiranServices.GetByGroupAndDate(group, startDate, endDate);
            return Ok(listAbsenMasuk.ConvertToDTO());
         }
         catch (Exception) {
            throw;
         }
      }

      [HttpGet("ExportToExcel/{group}/{startDate}/{endDate}")]
      public async Task<ActionResult<List<JadwalKehadiranDTO>>> ExportToExcel(string group, string? startDate, string? endDate) {
         try {
            var listAbsenMasuk = await _jadwalKehadiranService.GetByGroupAndDateRange(group, startDate, endDate);

            using (var wb = new XLWorkbook()) {
               var ws = wb.Worksheets.Add("Sheet1");

               ws.Cell(1, 1).Value = "Grup Kerja";
               ws.Cell(1, 2).Value = "Tanggal";
               ws.Cell(1, 3).Value = "NIK";
               ws.Cell(1, 4).Value = "Nama";
               ws.Cell(1, 5).Value = "Jam Masuk";
               ws.Cell(1, 6).Value = "Jam Pulang";
               ws.Cell(1, 7).Value = "Terlambat";

               for (int r = 1; r <= listAbsenMasuk!.Count-1; r++) {
                  ws.Cell(r + 1, 1).Value = listAbsenMasuk[r].GrupKerja;
                  ws.Cell(r + 1, 2).Value = listAbsenMasuk[r].JadwalMasuk!.Value.Date.ToString("dd-MM-yyyy");
                  ws.Cell(r + 1, 3).Value = listAbsenMasuk[r].NIK;
                  ws.Cell(r + 1, 4).Value = listAbsenMasuk[r].Nama;
                  ws.Cell(r + 1, 5).Value = listAbsenMasuk[r].JamMasuk;
                  ws.Cell(r + 1, 6).Value = listAbsenMasuk[r].JamPulang;
                  ws.Cell(r + 1, 7).Value = listAbsenMasuk[r].Terlambat;
               }
               // MemoryStream XLSStream = new();
               // wb.SaveAs(XLSStream);

               using (var stream = new MemoryStream()) {
                  wb.SaveAs(stream);
                  var content = stream.ToArray();
                  return File(
                     content,
                     "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                     "kehadiran.xlsx"
                  );
               }

            }
            //return Ok(listAbsenMasuk);
         }
         catch (Exception) {
            throw;
         }
      }

      [HttpGet("Terlambat/{startDate}/{endDate}")]
      public async Task<ActionResult<List<KehadiranDTO>>> GetTerlambat(string startDate, string endDate) {
         try {
            var listTerlambat = await kehadiranServices.GetTerlambat(startDate, endDate);
            return Ok(listTerlambat.ConvertToDTO());
         }
         catch (Exception) {

            throw;
         }
      }

      [HttpPost("Terlambat/Add")]
      public async Task<ActionResult<KehadiranDTO>> AddKeterlambatan([FromBody] JadwalKehadiranDTO terlambat) {
         try {
            var entity = await kehadiranServices.AddKeterlambatan(terlambat);
            return Ok(entity.ConvertToDTO());
         }
         catch (Exception) {

            throw;
         }
      }

      [HttpPut("Terlambat/Update")]
      public async Task<ActionResult<KehadiranDTO>> UpdateKeterlambatan(JadwalKehadiranDTO terlambat) {
         try {
            var entity = await kehadiranServices.UpdateKeterlambatan(terlambat);
            return Ok(entity.ConvertToDTO());
         }
         catch (Exception) {

            throw;
         }
      }

      [HttpGet("CountByEmpGender")]
      public async Task<ActionResult<int[]>> CountByEmpGender() {
         try {
            var rst = await kehadiranServices.CountEmpByGender();
            return Ok(rst);
         }
         catch (Exception) {
            throw;
         }
      }
   }
}
