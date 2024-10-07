using JadwalKerjaKaryawanAPI.Conversions;
using JadwalKerjaKaryawanAPI.Model;
using JadwalKerjaKaryawanAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SKM.Shared.Dtos;
using SKM.Shared.Helpers;

namespace JadwalKerjaKaryawanAPI.Controllers {
   [Route("api/[controller]")]
   [ApiController]
   public class JadwalKerjaKaryawanController : ControllerBase {
      private readonly IJadwalKerjaKaryawanService jadwalKerjaKaryawanService;
      private readonly ICacheService cacheService;
		private static object _lock = new();

      public JadwalKerjaKaryawanController(IJadwalKerjaKaryawanService jadwalKerjaKaryawanService, ICacheService cacheService)
        {
         this.jadwalKerjaKaryawanService = jadwalKerjaKaryawanService;
         this.cacheService = cacheService;
		}

      [HttpGet]
      public IEnumerable<JadwalKerjaKaryawan> GetJadwalAsync() {
         try {
            var cacheData = this.cacheService.GetData<IEnumerable<JadwalKerjaKaryawan>>("jadwalkerjakaryawan");
            if (cacheData != null) {
               //return StatusCode(StatusCodes.Status200OK, cacheData);

               return cacheData;
            }
            lock (_lock) {
               var expirationTime = DateTimeOffset.Now.AddHours(2.0);
               cacheData = (IEnumerable<JadwalKerjaKaryawan>?)this.jadwalKerjaKaryawanService.GetJadwalKerjaKaryawansAsync();
               this.cacheService.SetData<IEnumerable<JadwalKerjaKaryawan>>("jadwalkerjakaryawan", cacheData, expirationTime);
            }

            //return StatusCode(StatusCodes.Status200OK, cacheData);
            return cacheData;
            //lock (_lock) {

         }
         catch (System.Net.Http.HttpRequestException error) {
            Console.WriteLine(error.Message);
            var cacheData = this.cacheService.GetData<IEnumerable<JadwalKerjaKaryawan>>("jadwalkerjakaryawan");
            if (cacheData != null) {
               //return StatusCode(StatusCodes.Status200OK, cacheData);
               return cacheData;
            }
            lock (_lock) {
               var expirationTime = DateTimeOffset.Now.AddHours(2.0);
               cacheData = (IEnumerable<JadwalKerjaKaryawan>?)this.jadwalKerjaKaryawanService.GetJadwalKerjaKaryawansAsync();
               this.cacheService.SetData<IEnumerable<JadwalKerjaKaryawan>>("jadwalkerjakaryawan", cacheData, expirationTime);
            }
            return cacheData;
            //return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from database!");

            //throw;
         }
      }

      [HttpGet]
      [Route("NIK/{nik}")]
      public async Task<ActionResult<JadwalKerjaKaryawan>> GetByNIK(string nik) {
			try {
				JadwalKerjaKaryawan jadwal;
				var cacheData = this.cacheService.GetData<IEnumerable<JadwalKerjaKaryawan>>("jadwalkerjakaryawan");
				if (cacheData != null) {
					jadwal = cacheData.Where(e => e.NIK == nik).FirstOrDefault();
					return StatusCode(StatusCodes.Status200OK, jadwal);
				}
            jadwal = await this.jadwalKerjaKaryawanService.GetByNIK(nik);
				return StatusCode(StatusCodes.Status200OK, jadwal);
			}
			catch (Exception) {
				return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from database");
			}
		}

      [HttpGet]
      [Route("GroupName/{groupName}")]
      public async Task<ActionResult<JadwalKerjaKaryawan>> GetByGroupName(string groupName) {
         try {
            List<JadwalKerjaKaryawan> listJadwal;
            //var cacheData = this.cacheService.GetData<IEnumerable<JadwalKerjaKaryawan>>("jadwalkerjakaryawan");
            //if (cacheData != null) {
            //   string strGroupName = groupName.Replace("-", "/");
            //   listJadwal = cacheData.Where(j => j.GroupName == strGroupName).ToList();
            //   return StatusCode(StatusCodes.Status200OK, listJadwal);
            //}
            listJadwal = await this.jadwalKerjaKaryawanService.GetByGroupName(groupName);
            return StatusCode(StatusCodes.Status200OK, listJadwal);
         }
         catch (Exception) {
            return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from database");
         }
      }

      [HttpGet("{id}")]
      public async Task<ActionResult<JadwalKerjaKaryawanDTO>> GetById(int id) {
         try {
            JadwalKerjaKaryawan jadwal;
            var cacheData = this.cacheService.GetData<IEnumerable<JadwalKerjaKaryawan>>("jadwalkerjakaryawan");
            if (cacheData != null) {
               jadwal = cacheData.Where(e => e.Id == id).FirstOrDefault();
               return StatusCode(StatusCodes.Status200OK, jadwal);
            }
            jadwal = await this.jadwalKerjaKaryawanService.GetById(id);
            return StatusCode(StatusCodes.Status200OK, jadwal);
         }
         catch (Exception) {
            return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from database");
         }
      }

      [HttpPost("AddRange")]
      public async Task<ActionResult<JadwalKerjaKaryawan>> AddJadwalRange([FromBody]IEnumerable<JadwalKerjaKaryawanDTO> jadwalDTOs) {
         try {
            var newJadwal = await this.jadwalKerjaKaryawanService.AddJadwalKerjaKaryawanRange(jadwalDTOs);
            this.cacheService.RemoveData("jadwalkerjakaryawan");
            return Ok(default);
         }
         catch (Exception) {

            throw;
         }
      }

      [HttpPut]
      [Route("UpdateRange")]
      public async Task<ActionResult<JadwalKerjaKaryawan>> UpdateRange(IEnumerable<JadwalKerjaKaryawanDTO> jadwalDTOs) {
         var jadwal = await this.jadwalKerjaKaryawanService.UpdateJadwalKerjaKaryawanRange(jadwalDTOs);
         this.cacheService.RemoveData("jadwalkerjakaryawan");

         return Ok(default);
      }

		[HttpPut("UpdateSingle")]
		public async Task<ActionResult<JadwalKerjaKaryawan>> UpdateSingle([FromBody] JadwalKerjaKaryawanDTO jadwalDTO) {
			var jadwal = await this.jadwalKerjaKaryawanService.UpdateJadwalKerja(jadwalDTO);
			this.cacheService.RemoveData("jadwalkerjakaryawan");

			return Ok(jadwal);
		}

      [HttpGet("GroupAndDate/{group}/{startDate}/{endDate}")]
      public async Task<ActionResult<JadwalKerjaKaryawanDTO>> GetByGroupAndDate(string group, string startDate, string endDate) {
         try {
            List<JadwalKerjaKaryawan> listJadwal;
            //var cacheData = this.cacheService.GetData<IEnumerable<JadwalKerjaKaryawan>>("jadwalkerjakaryawan");
            //if (cacheData != null) {
            //   string strGroupName = group.Replace("-", "/").Replace("_"," ");
            //   DateTime date1 = DateConversions.StringToDate(startDate);
            //   DateTime date2 = DateConversions.StringToDate(endDate);

            //   listJadwal = cacheData.Where(j => j.GroupName == strGroupName && j.Tgl >= date1 && j.Tgl <= date2).ToList();
            //   return StatusCode(StatusCodes.Status200OK, listJadwal);
            //}
            listJadwal = await this.jadwalKerjaKaryawanService.GetByGroupAndDate(group, startDate, endDate);
            return Ok(listJadwal.ConvertToDTO());
         }
         catch (Exception) {
            return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from database");
         }
      }

		[HttpGet("NIKAndDate/{nik}/{strDate}")]
		public async Task<ActionResult<JadwalKerjaKaryawanDTO>> GetByNIKAndDate(string nik,  string strDate) {
			try {
				JadwalKerjaKaryawan? jadwalKaryawan;
            DateTime date = DateConversions.StringToDate(strDate);

				var cacheData = this.cacheService.GetData<IEnumerable<JadwalKerjaKaryawan>>("jadwalkerjakaryawan");
				if (cacheData != null) {
					jadwalKaryawan = cacheData.Where(j => j.NIK == nik && j.Tgl.Value.Date == date.Date).SingleOrDefault();
            }
            else {
					jadwalKaryawan = await this.jadwalKerjaKaryawanService.GetByNIKAndDate(nik, date);
				}
            return Ok(jadwalKaryawan?.ConvertToDTO());

				//if (jadwalKaryawan is not null) {
				//	KehadiranDTO newAbsen = new() {
				//		GrupKerja = jadwalKaryawan.GroupName,
				//		NIK = jadwalKaryawan.NIK,
				//		Nama = jadwalKaryawan.NamaKaryawan,
				//		Tanggal = date.Date,
				//		JadwalMasuk = jadwalKaryawan.JamMasuk,
				//		JamMasuk = DateTime.Now.TimeOfDay,
				//		JadwalPulang = jadwalKaryawan.JamPulang
				//	};
				//	var kehadiran = await kehadiranServices.Absen(newAbsen);
				//	return Ok(kehadiran?.ConvertToDTO());
    //        }
    //        else {
    //           return null;
    //        }
			}
			catch (Exception) {
				return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from database");
			}
		}

		[HttpDelete("{id}")]
      //[Authorize(Roles = "Administrator")]
      public async Task<ActionResult<JadwalKerjaKaryawanDTO>> DeleteJadwalKerjaKaryawanAsync(int id) {
         //return departmentService.DeleteDepartmentAsync(id);
         JadwalKerjaKaryawan jadwalKerjaKaryawan = await jadwalKerjaKaryawanService.DeleteJadwalKerjaKaryawanAsync(id);

         cacheService.RemoveData("jadwalkerjakaryawan");
         return jadwalKerjaKaryawan.ConvertToDTO();

      }

		[HttpGet("GetByDate/{date}")]
		public async Task<ActionResult<JadwalKerjaKaryawanDTO>> GetByDate(DateTime date) {
			try {
				List<JadwalKerjaKaryawan>? Empschedules;
				var cacheData = this.cacheService.GetData<IEnumerable<JadwalKerjaKaryawan>>("jadwalkerjakaryawan");
				if (cacheData != null) {
					Empschedules = cacheData.Where(j => j.Tgl.Value.Date == date.Date).ToList();
				}
				else {
					Empschedules = await this.jadwalKerjaKaryawanService.GetByDate(date);
				}
				return Ok(Empschedules?.ConvertToDTO());

			}
			catch (Exception) {
				return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from database");
			}
		}

	}
}
