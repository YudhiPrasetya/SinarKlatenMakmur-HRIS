using ClosedXML.Excel;
using MesinAbsenAPI.Conversions;
using MesinAbsenAPI.Models;
using MesinAbsenAPI.RabbitMQ;
using MesinAbsenAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SKM.Shared.Dtos;
using SKM.Shared.Helpers;

namespace MesinAbsenAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class MesinAbsensController : ControllerBase
  {
    private readonly IMesinAbsenService MesinAbsenService;
		private readonly ILogMesinAbsenService _logMesinAbsenService;
		private readonly ICacheService _cacheService;
		private readonly IRabbitMQProducer _rabbitMQProducer;

		public MesinAbsensController(IMesinAbsenService mesinAbsenService, ILogMesinAbsenService logMesinAbsenService, ICacheService cacheService, IRabbitMQProducer rabbitMQProducer)
    {
      MesinAbsenService = mesinAbsenService;
			_logMesinAbsenService = logMesinAbsenService;
			_cacheService = cacheService;
			_rabbitMQProducer = rabbitMQProducer;
		}

    [HttpGet]
    //[Authorize]
    public async Task<ActionResult> MesinAbsenListAync()
    {
         try {
            var cacheData = _cacheService.GetData<IEnumerable<MesinAbsen>>("mesinAbsen");
            if (cacheData != null) {
               return StatusCode(StatusCodes.Status200OK, cacheData);
            }
            //lock (_lock) {
            var expirationTime = DateTimeOffset.Now.AddHours(2.0);
            cacheData = await MesinAbsenService.GetMesinAbsenListAsync();
            _cacheService.SetData<IEnumerable<MesinAbsen>>("mesinAbsen", (IEnumerable<MesinAbsen>)cacheData, expirationTime);
            return StatusCode(StatusCodes.Status200OK, cacheData);
         }
         catch (System.Net.Http.HttpRequestException error) {
            Console.WriteLine(error.ToString());
            var cacheData = _cacheService.GetData<IEnumerable<MesinAbsen>>("mesinAbsen");
            if (cacheData != null) {
               return StatusCode(StatusCodes.Status200OK, cacheData);
            }
            //lock (_lock) {
            var expirationTime = DateTimeOffset.Now.AddHours(2.0);
            cacheData = await MesinAbsenService.GetMesinAbsenListAsync();
            _cacheService.SetData<IEnumerable<MesinAbsen>>("mesinAbsen", (IEnumerable<MesinAbsen>)cacheData, expirationTime);
            return StatusCode(StatusCodes.Status200OK, cacheData);

            //throw;
         }

      }

    [HttpGet("{id}")]
    //[Authorize]
    public async Task<ActionResult<MesinAbsenDTO>> GetMesinAbsenById(int id)
    {
         //return MesinAbsenService.GetMesinAbsenByIdAsync(id);
         MesinAbsen mesinAbsen;
         var cacheData = _cacheService.GetData<IEnumerable<MesinAbsen>>("mesinAbsen");
         if (cacheData != null) {
            mesinAbsen = cacheData.Where(ma => ma.DeviceID == id).FirstOrDefault();
            return StatusCode(StatusCodes.Status200OK, mesinAbsen);
         }
         mesinAbsen = await MesinAbsenService.GetMesinAbsenByIdAsync(id);
         return StatusCode(StatusCodes.Status200OK, mesinAbsen);
      }

    [HttpPost]
    //[Authorize(Roles = "Administrator")]
    public async Task<ActionResult<MesinAbsenDTO>> AddMesinAbsenAsync([FromBody]MesinAbsenDTO mesinAbsenDTO)
    {
      //return MesinAbsenService.AddMesinAbsenAsync(mesinAbsen);
      var newMesinAbsen = await MesinAbsenService.AddMesinAbsenAsync(mesinAbsenDTO.ConvertToModel());
      if (newMesinAbsen == null) {
         return NoContent();
      }
      _cacheService.RemoveData("mesinAbsen");
      return Ok(newMesinAbsen.ConvertToDTO());
    }

	[HttpPost("addlogmesinabsen")]
	//[Authorize(Roles = "Administrator")]
	public async Task<ActionResult<bool>> AddMesinAbsenLogRangeAsync([FromBody] ContentLogMesinDTO contentLogMesinDTO) {
      bool rst = await _logMesinAbsenService.AddLogMesinAbsenRange(contentLogMesinDTO);
      _rabbitMQProducer.SendLogMesinAbsenMessage(contentLogMesinDTO);
		return Ok(rst);
	}

	[HttpPut]
   //[Authorize(Roles = "Administrator")]
   public async Task<ActionResult<MesinAbsenDTO>> UpdateMesinAbsenAsync(MesinAbsenDTO mesinAbsenDTO) {
      //return MesinAbsenService.UpdateMesinAbsenAsync(mesinAbsen);
      MesinAbsen mesinAbsen = await MesinAbsenService.UpdateMesinAbsenAsync(mesinAbsenDTO.ConvertToModel());
      _cacheService.RemoveData("mesinAbsen");
      
      return mesinAbsen.ConvertToDTO();

   }

    [HttpDelete("{id}")]
    //[Authorize(Roles = "Admnistrator")]
    public async Task<ActionResult<MesinAbsenDTO>> DeleteMesinAbsenAsync(int id)
    {
         //return MesinAbsenService.DeleteMesinAbsenAsync(id);
         MesinAbsen mesinAbsen = await MesinAbsenService.DeleteMesinAbsenAsync(id);
         _cacheService.RemoveData("mesinAbsen");
         return mesinAbsen.ConvertToDTO();
    }

      [HttpGet("Log/{startDate}/{endDate}")]
      public async Task<ActionResult<List<LogMesinAbsenDTO>>> GetLogMesinAbsenByDate(string startDate, string endDate) {
         DateTime sDate = DateConversions.StringToDate(startDate);
         DateTime eDate = DateConversions.StringToDate(endDate);
         var listLogMesinAbsen = await _logMesinAbsenService.GetLogMesinAbsenByDate(sDate, eDate);
         ContentLogMesinDTO contentLogMesinDTO = new ContentLogMesinDTO {
            IpAddress = "192.168.90.94",
            NoMesin = 3,
            Port = 4307,
            StartDate = Convert.ToDateTime(sDate),
            EndDate = Convert.ToDateTime(eDate),
            ListLogMesinAbsen = listLogMesinAbsen
         };
         
         _rabbitMQProducer.SendLogMesinAbsenMessage(contentLogMesinDTO);
         return Ok(contentLogMesinDTO);
      }

      [HttpGet("Log/ExportToExcel/{startDate}/{endDate}")]
      public async Task<ActionResult<List<LogMesinAbsenDTO>>> ExportToExcel(string startDate, string endDate) {
         DateTime sDate = DateConversions.StringToDate(startDate);
         DateTime eDate = DateConversions.StringToDate(endDate);

         try {
            var listLogMesinAbsen = await _logMesinAbsenService.GetLogMesinAbsenByDate(sDate, eDate);
            using var wb = new XLWorkbook();
            var ws = wb.Worksheets.Add("Sheet1");

            ws.Cell(1, 1).Value = "NIK";
            ws.Cell(1, 2).Value = "Tanggal";
            for (int r = 0; r < listLogMesinAbsen.Count; r++) {
               ws.Cell(r + 1, 1).Value = listLogMesinAbsen[r].NIK;
               ws.Cell(r + 1, 2).Value = listLogMesinAbsen[r].Tgl;
            }
            using (var stream = new MemoryStream()) {
               wb.SaveAs(stream);
               var content = stream.ToArray();
               return File(
                  content,
                  "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                  "LogMesinAbsen.xlsx"
               );
            }
         }
         catch (Exception) {

            throw;
         }


      }

  }
}
