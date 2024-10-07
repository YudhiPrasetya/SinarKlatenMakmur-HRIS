using GajiDanTunjanganAPI.Conversions;
using GajiDanTunjanganAPI.Model;
using GajiDanTunjanganAPI.Services;
using MassTransit;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SKM.Shared.Dtos;
using SKM.Shared.Models;

namespace GajiDanTunjanganAPI.Controllers {
   [Route("api/[controller]")]
   [ApiController]
   public class GajiController : ControllerBase {
      private readonly IGajiDanTunjanganService gajiDanTunjanganService;
      private readonly ICacheService cacheService;
      private readonly IBus _bus;
      private static object _lock = new();

      public GajiController(IGajiDanTunjanganService gajiDanTunjanganService, ICacheService cacheService)
      {
         this.gajiDanTunjanganService = gajiDanTunjanganService;
         this.cacheService = cacheService;
         //_bus = bus;
      }

      [HttpGet]
      //[Authorize]
      //public async Task<ActionResult<IEnumerable<DepartmentDTO>>> DepartmentListAsync()
      public IEnumerable<GajiDanTunjanganAPI.Model.GajiDanTunjangan> GetGajiAsync() {
         try {
            var cacheData = this.cacheService.GetData<IEnumerable<GajiDanTunjanganAPI.Model.GajiDanTunjangan>>("gaji");
            if (cacheData != null) {
               //return StatusCode(StatusCodes.Status200OK, cacheData);
               return cacheData;
            }
            lock (_lock) {
               var expirationTime = DateTimeOffset.Now.AddHours(2.0);
               cacheData = (IEnumerable<GajiDanTunjanganAPI.Model.GajiDanTunjangan>?)this.gajiDanTunjanganService.GetGajiDanTunjanganListAsync();
               this.cacheService.SetData<IEnumerable<GajiDanTunjanganAPI.Model.GajiDanTunjangan>>("gaji", cacheData, expirationTime);
            }

            //return StatusCode(StatusCodes.Status200OK, cacheData);
            return cacheData;
            //lock (_lock) {

         }
         catch (System.Net.Http.HttpRequestException error) {
            Console.WriteLine(error.Message);
            var cacheData = this.cacheService.GetData<IEnumerable<GajiDanTunjanganAPI.Model.GajiDanTunjangan>>("gaji");
            if (cacheData != null) {
               //return StatusCode(StatusCodes.Status200OK, cacheData);
               return cacheData;
            }
            lock (_lock) {
               var expirationTime = DateTimeOffset.Now.AddHours(2.0);
               cacheData = (IEnumerable<GajiDanTunjanganAPI.Model.GajiDanTunjangan>?)this.gajiDanTunjanganService.GetGajiDanTunjanganListAsync();
               this.cacheService.SetData<IEnumerable<GajiDanTunjanganAPI.Model.GajiDanTunjangan>>("gaji", cacheData, expirationTime);
            }
            return cacheData;
            //return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from database!");

            //throw;
         }
      }

      [HttpGet("{id}")]
      public async Task<ActionResult<GajiDanTunjanganAPI.Model.GajiDanTunjangan>> GetGajiByIdAsync(int id) {
         try {
            GajiDanTunjanganAPI.Model.GajiDanTunjangan gaji;
            var cacheData = this.cacheService.GetData<IEnumerable<GajiDanTunjanganAPI.Model.GajiDanTunjangan>>("gaji");
            if (cacheData != null) {
               gaji = cacheData.Where(e => e.Id == id).FirstOrDefault();
               return StatusCode(StatusCodes.Status200OK, gaji);
            }
            gaji = await this.gajiDanTunjanganService.GetGajiDanTunjanganByIdAsync(id);
            return StatusCode(StatusCodes.Status200OK, gaji);
         }
         catch (Exception) {
            return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from database");
         }
      }

      [HttpGet("NIK/{nik}")]
      public async Task<ActionResult<GajiDanTunjanganAPI.Model.GajiDanTunjangan>> GetGajiByNIKAsync(string nik) {
         try {
            GajiDanTunjanganAPI.Model.GajiDanTunjangan gaji;
            var cacheData = this.cacheService.GetData<IEnumerable<GajiDanTunjanganAPI.Model.GajiDanTunjangan>>("gaji");
            if (cacheData != null) {
               gaji = cacheData.Where(e => e.NIK == nik).FirstOrDefault();
               return StatusCode(StatusCodes.Status200OK, gaji);
            }
            gaji = await this.gajiDanTunjanganService.GetGajiByNIKAsync(nik);
            return StatusCode(StatusCodes.Status200OK, gaji);
         }
         catch (Exception) {
            return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from database");
         }
      }

      [HttpGet("Group/{groupId}")]
      public async Task<ActionResult<GajiDanTunjanganAPI.Model.GajiDanTunjangan>> GetGajiByGroupIdAsync(int groupId) {
         try {
            IEnumerable<Model.GajiDanTunjangan> gajis;
            var cacheData = this.cacheService.GetData<IEnumerable<GajiDanTunjanganAPI.Model.GajiDanTunjangan>>("gaji");
            if (cacheData != null) {
               gajis = cacheData.Where(g => g.GroupId == groupId).ToList();
               return StatusCode(StatusCodes.Status200OK, gajis);
            }
            gajis = await this.gajiDanTunjanganService.GetGajiDanTunjanganByIdGroupAsync(groupId);
            return StatusCode(StatusCodes.Status200OK, gajis);
         }
         catch (Exception) {
            return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from database");
         }
      }

      [HttpGet("GroupName/{groupName}")]
      public async Task<ActionResult<GajiDanTunjanganDTO>> GetByGroupName(string groupName) {
         try {
            IEnumerable<Model.GajiDanTunjangan> gajis;
            var cacheData = this.cacheService.GetData<IEnumerable<GajiDanTunjanganAPI.Model.GajiDanTunjangan>>("gaji");
            if (cacheData != null) {
               gajis = cacheData.Where(g => g.GrupKerja == groupName).ToList();
               return StatusCode(StatusCodes.Status200OK, gajis.ConvertToDtO());
            }
            gajis = await this.gajiDanTunjanganService.GetByGroupName(groupName);
            return StatusCode(StatusCodes.Status200OK, gajis.ConvertToDtO());
         }
         catch (Exception) {
            return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from database");
         }
      }

      [HttpPost]
      public async Task<ActionResult<GajiDanTunjanganAPI.Model.GajiDanTunjangan>> AddGaji([FromBody] GajiDanTunjanganDTO gajiDTO) {
         try {
            var newGaji = await this.gajiDanTunjanganService.AddGajiDanTunjanganAsync(gajiDTO.ConvertToModel());
            if (newGaji == null) {
               return NoContent();
            }
            //Uri uri = new("rabbitmq://localhost/gajidantunjangan");
            //var endpoint = await _bus.GetSendEndpoint(uri);
            //await endpoint.Send(new GajiDanTunjanganCreated {
            //   Id = newGaji.Id,
            //   NIK = newGaji.NIK,
            //   NamaKaryawan = newGaji.NamaKaryawan,
            //   Upah = newGaji.Upah,
            //   PTKP = newGaji.PTKP,
            //   PTKP_Jumlah = newGaji.PTKP_Jumlah,
            //   TunjJabatan = newGaji.TunjJabatan,
            //   TunjKeterampilan = newGaji.TunjKeterampilan,
            //   TunjMasaKerja = newGaji.TunjMasaKerja,
            //   TunjLain = newGaji.TunjLain,
            //   PotonganKoperasi = newGaji.PotonganKoperasi,
            //   PotonganLain = newGaji.PotonganLain,
            //   Potong_BPJSKes = newGaji.Potong_BPJSKes,
            //   Potong_BPJSTK = newGaji.Potong_BPJSTK,
            //   BPJS_Ortu1 = newGaji.BPJS_Ortu1,
            //   BPJS_Ortu2 = newGaji.BPJS_Ortu2,
            //   BPJS_Ortu3 = newGaji.BPJS_Ortu3,
            //   BPJS_Ortu4 = newGaji.BPJS_Ortu4,
            //   GroupId = newGaji.GroupId,
            //   GrupKerja = newGaji.GrupKerja,
            //   DepartmentId = newGaji.DepartmentId,
            //   DepartmentName = newGaji.DepartmentName
            //});
            this.cacheService.RemoveData("gaji");
            return Ok(newGaji.ConvertToDTO());
         }
         catch (Exception) {

            throw;
         }
      }

      [HttpPost("AddGajiRange")]
      public async Task<ActionResult<Model.GajiDanTunjangan>> AddGajiRange([FromBody] IEnumerable<GajiDanTunjanganDTO> gajiDTOs) {
         try {
            //var newGaji = await gajiDanTunjanganService.AddGajiDanTunjanganRangeAsync(gajiDTOs);
            //if (newGaji == null) {
            //   return NoContent();
            //}
            var newGaji = await gajiDanTunjanganService.AddGajiDanTunjanganRangeAsync(gajiDTOs);

            //Uri uri = new("rabbitmq://localhost/gajidantunjangan_range");
            //var endpoint = await _bus.GetSendEndpoint(uri);
            //List<GajiDanTunjanganCreated> listGajiCreated = new();
            //foreach(var gaji in gajiDTOs) {
            //   listGajiCreated.Add(new GajiDanTunjanganCreated {
            //      Id = gaji.Id,
            //      NIK = gaji.NIK,
            //      NamaKaryawan = gaji.NamaKaryawan,
            //      Upah = gaji.Upah,
            //      PTKP = gaji.PTKP,
            //      PTKP_Jumlah = gaji.PTKP_Jumlah,
            //      TunjJabatan = gaji.TunjJabatan,
            //      TunjKeterampilan = gaji.TunjKeterampilan,
            //      TunjMasaKerja = gaji.TunjMasaKerja,
            //      TunjLain = gaji.TunjLain,
            //      PotonganKoperasi = gaji.PotonganKoperasi,
            //      PotonganLain = gaji.PotonganLain,
            //      Potong_BPJSKes = gaji.Potong_BPJSKes,
            //      Potong_BPJSTK = gaji.Potong_BPJSTK,
            //      BPJS_Ortu1 = gaji.BPJS_Ortu1,
            //      BPJS_Ortu2 = gaji.BPJS_Ortu2,
            //      BPJS_Ortu3 = gaji.BPJS_Ortu3,
            //      BPJS_Ortu4 = gaji.BPJS_Ortu4,
            //      GroupId = gaji.GroupId,
            //      GrupKerja = gaji.GrupKerja,
            //      DepartmentId = gaji.DepartmentId,
            //      DepartmentName = gaji.DepartmentName,
            //      EmployeeId = gaji.EmployeeId
            //   });
            //};
            ////await endpoint.Send(listGajiCreated);
            //await endpoint.SendBatch(listGajiCreated);
            cacheService.RemoveData("gaji");
            return Ok(default);
         }
         catch (Exception) {

            throw;
         }
      }

      [HttpPut()]
      public async Task<ActionResult<GajiDanTunjanganDTO>> UpdateGajiAsync(GajiDanTunjanganDTO gajiDTO) {
         GajiDanTunjanganAPI.Model.GajiDanTunjangan gaji = await this.gajiDanTunjanganService.UpdateGajiDanTunjanganAsync(gajiDTO.ConvertToModel());
            this.cacheService.RemoveData("gaji");
         //rabbitMqProducer.SendDepartmentMessage(department);
         return gaji.ConvertToDTO();
      }

      [HttpDelete("{id}")]
      //[Authorize(Roles = "Administrator")]
      public async Task<ActionResult<GajiDanTunjanganDTO>> DeleteGajiAsync(int id) {
         //return departmentService.DeleteDepartmentAsync(id);
         GajiDanTunjanganAPI.Model.GajiDanTunjangan gaji = await this.gajiDanTunjanganService.DeleteGajiDanTunjanganAsync(id);

         this.cacheService.RemoveData("gaji");
         return gaji.ConvertToDTO();

      }
   }
}
