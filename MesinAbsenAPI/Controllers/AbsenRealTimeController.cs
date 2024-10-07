using MesinAbsenAPI.RabbitMQ;
using MesinAbsenAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SKM.Shared.Dtos;

namespace MesinAbsenAPI.Controllers {
   [Route("api/[controller]")]
   [ApiController]
   public class AbsenRealTimeController : ControllerBase {
      private readonly IAbsenRealTimeService absenRealTimeService;
      private readonly IRabbitMQProducer rabbitMQProducer;

      public AbsenRealTimeController(IAbsenRealTimeService absenRealTimeService, IRabbitMQProducer rabbitMQProducer) {
         this.absenRealTimeService = absenRealTimeService;
         this.rabbitMQProducer = rabbitMQProducer;
      }

      [HttpPost("addabsenrealtime")]
      public async Task<ActionResult<AbsenRealTimeDTO>> AddAbsenRealTime([FromBody] AbsenRealTimeDTO absenRealTimeDTO) {
         var art = await absenRealTimeService.Add(absenRealTimeDTO);
         this.rabbitMQProducer.SendAbsenRealTimeMessage(art);
         return Ok(art);
      }

      [HttpPost("AddAbsenRealTimeForPayroll")]
      public async Task<ActionResult<PayrollDTO>> AbsenRealTimeForPayroll([FromBody] PayrollDTO payrollDTO) {
         await Task.Delay(10);
         this.rabbitMQProducer.SendRealtimeMessageToPayroll(payrollDTO);
         return Ok(payrollDTO);
      }
   }
}
