using GroupAPI.Model;
using GroupAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using System.Text.Json;
using System.Text;
using SKM.Shared.Dtos;
using GroupAPI.Conversions;
using MassTransit;
using SKM.Shared.Models;
using Microsoft.AspNetCore.Authorization;

namespace GroupAPI.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class GroupController : ControllerBase {
      private readonly IGroupService _groupService;
      private readonly ICacheService _cacheService;
      private readonly IBus _bus;

      //private readonly IDistributedCache _cache;

      public GroupController(IGroupService groupService, ICacheService cacheService, IBus bus) {
         _groupService = groupService;
         _cacheService = cacheService;
         _bus = bus;
         //_cache = cache;
      }

      [HttpGet]
      public async Task<ActionResult<IEnumerable<Group>>> GetAllGroups() {
         //var groups = await _groupService.GetGroups();
         //if(groups == null) {
         //   return NoContent();
         //}
         //return Ok(groups);
         var cacheData = _cacheService.GetData<IEnumerable<Group>>("group");
         if (cacheData != null) {
            return StatusCode(StatusCodes.Status200OK, cacheData);
         }
         //lock (_lock) {
         var expirationTime = DateTimeOffset.Now.AddHours(2.0);
         cacheData = await _groupService.GetGroups();
         _cacheService.SetData<IEnumerable<Group>>("group", (IEnumerable<Group>)cacheData, expirationTime);
         return StatusCode(StatusCodes.Status200OK, cacheData);
      }

      [HttpGet("{id}")]
      public async Task<ActionResult<Group>> GetGroup(int id) {
         Group group;
         var cacheData = _cacheService.GetData<IEnumerable<Group>>("group");
         if (cacheData != null) {
            group = cacheData.Where(e => e.GroupID == id).FirstOrDefault();
            return StatusCode(StatusCodes.Status200OK, group);
         }
         group = await _groupService.GetGroupById(id);
         return StatusCode(StatusCodes.Status200OK, group);
      }

      [HttpPost]
      //[Authorize(Roles = "Administrator")]
      public async Task<ActionResult<GroupDTO>> AddGroup([FromBody] GroupDTO groupDTO) {
         //var departmentData = departmentService.AddDepartment(department);
         ////rabbitMqProducer.SendDepartmentMessage(departmentData);
         //return departmentData;
         try {
            var newGroup = await _groupService.AddGroup(groupDTO);
            if (newGroup == null) {
               return NoContent();
            }
            _cacheService.RemoveData("group");
            return Ok(newGroup.ConvertToDTO());
         }
         catch (Exception) {

            throw;
         }
      }

      [HttpPut]
      //[Authorize(Roles = "Administrator")]
      public async Task<ActionResult<GroupDTO>> UpdateGroupAsync(GroupDTO groupDTO) {
         Group group = await _groupService.UpdateGroupAsync(groupDTO);
         //Uri uri = new Uri("rabbitmq://localhost/group");
         //var endPoint = await _bus.GetSendEndpoint(uri);
         //await endPoint.Send(new WorkGroupCreated {
         //   GroupID = group.GroupID,
         //   GroupDesc = group.GroupDesc
         //});
         _cacheService.RemoveData("group");
         //rabbitMqProducer.SendDepartmentMessage(department);
         return group.ConvertToDTO();
      }

      [HttpDelete("{id}")]
      //[Authorize(Roles = "Administrator")]
      public async Task<ActionResult<GroupDTO>> DeleteGroupAsync(int id) {
         //return departmentService.DeleteDepartmentAsync(id);
         Group group = await _groupService.DeleteGroupAsync(id);


         _cacheService.RemoveData("group");
         return group.ConvertToDTO();

      }

      [HttpGet("GroupName/{groupName}")]
      public async Task<ActionResult<List<GroupDTO>?>> GetByGroupName(string groupName) {

			var rst = await _groupService.GetByGroupName(groupName);
			return StatusCode(StatusCodes.Status200OK, rst);
		}

   }
}
