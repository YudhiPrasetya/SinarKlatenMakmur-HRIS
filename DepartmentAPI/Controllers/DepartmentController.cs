using DepartmentAPI.Conversions;
using DepartmentAPI.Models;
//using DepartmentAPI.RabbitMq;
using DepartmentAPI.Services;
using MassTransit;
using Microservices.DepartmentAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
//using Newtonsoft.Json;
using SKM.Shared.Dtos;
using SKM.Shared.Models;
using System.Text;
using System.Text.Json;
//using System.Text.Json;
using AuthAPI;

namespace DepartmentAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	//[JwtTokenValidate]
	public class DepartmentController : ControllerBase
	{
		private readonly IDepartmentService departmentService;
      private readonly ICacheService _cache;
      private readonly IBus _bus;
      private static object _lock = new();
		//private readonly IDistributedCache _cache;

		//private readonly IRabbitMqProducer rabbitMqProducer;

		public DepartmentController(IDepartmentService _departmentService, ICacheService cache, IBus bus)
		{
			departmentService = _departmentService;
         _cache = cache;
         _bus = bus;
         //_cache = cache;
         //rabbitMqProducer = _rabbitMqProducer;
      }

		[HttpGet]
		//[Authorize]
		//public async Task<ActionResult<IEnumerable<DepartmentDTO>>> DepartmentListAsync()
		public IEnumerable<Department> GetDepartmentListAsync()
		{
			try
			{
            var cacheData = _cache.GetData<IEnumerable<Department>>("department");
            if (cacheData != null) {
					//return StatusCode(StatusCodes.Status200OK, cacheData);
					return cacheData;
				}
				lock (_lock) {
               var expirationTime = DateTimeOffset.Now.AddHours(2.0);
               cacheData = (IEnumerable<Department>?)departmentService.GetDepartmentListAsync();
               _cache.SetData<IEnumerable<Department>>("department", cacheData, expirationTime);
            }

				//return StatusCode(StatusCodes.Status200OK, cacheData);
				return cacheData;
            //lock (_lock) {

         }
			catch (Exception)
			{
				//return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from database!");
				throw;
			}
		}

		[HttpGet("{id:int}")]
		//[Authorize]
		public async Task<ActionResult<DepartmentDTO>> GetDepartmentByIdAsync(int id)
		{
			try
			{
            Department department;
            var cacheData = _cache.GetData<IEnumerable<Department>>("department");
            if (cacheData != null) {
               department = cacheData.Where(e => e.DepartmentID == id).FirstOrDefault();
               return StatusCode(StatusCodes.Status200OK, department);
            }
            department = await departmentService.GetDepartmentByIdAsync(id);
            return StatusCode(StatusCodes.Status200OK, department);
         }
			catch (Exception)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from database");
			}
		}

		[HttpPost]
		//[Authorize(Roles = "Administrator")]
		public async Task<ActionResult<DepartmentDTO>> AddDepartment([FromBody] DepartmentDTO departmentDTO)
		{
			//var departmentData = departmentService.AddDepartment(department);
			////rabbitMqProducer.SendDepartmentMessage(departmentData);
			//return departmentData;
			try
			{
            var newDepartment = await departmentService.AddDepartment(departmentDTO);
            if (newDepartment == null) {
               return NoContent();
            }
            _cache.RemoveData("department");
            return Ok(newDepartment.ConvertToDTO());
         }
			catch (Exception)
			{

				throw;
			}
		}

		[HttpPut]
		//[Authorize(Roles = "Administrator")]
		public async Task<ActionResult<DepartmentDTO>> UpdateDepartmentAsync(DepartmentDTO departmentDTO)
		{
         Department department = await departmentService.UpdateDepartmentAsync(departmentDTO);
         Uri uri = new("rabbitmq://localhost/department");
         var endPoint = await _bus.GetSendEndpoint(uri);
			await endPoint.Send(new DepartmentCreated {
				DepartmentID = department.DepartmentID,
				DepartmentName = department.DepartmentName,
				DepartmentDescription = department.DepartmentDescription,
				CreatedBy = department.CreatedBy,
				CreatedAt = department.CreatedAt,
				IsActive = department.IsActive,
				UpdatedAt = department.UpdatedAt,
				UpdatedBy = department.UpdatedBy
			});
         _cache.RemoveData("department");
			//rabbitMqProducer.SendDepartmentMessage(department);
         return department.ConvertToDTO();
      }

		[HttpDelete("{id}")]
		//[Authorize(Roles = "Administrator")]
		public async Task<ActionResult<DepartmentDTO>> DeleteDepartmentAsync(int id)
		{
         //return departmentService.DeleteDepartmentAsync(id);
         Department department = await departmentService.DeleteDepartmentAsync(id);


         _cache.RemoveData("department");
         return department.ConvertToDTO();

      }

		[HttpPost("sendoffer")]
		public bool SendDepartmentOfferAsync(DepartmentOffer departmentOffer) {
			bool isSent = false;
			if (departmentOffer != null) {
				isSent = departmentService.SendDepartmentOffer(departmentOffer);
				return isSent;
			}
			return isSent;
		}

	}
}
