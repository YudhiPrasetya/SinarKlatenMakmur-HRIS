using GroupAPI.Conversions;
using GroupAPI.Data;
using GroupAPI.Model;
using Microsoft.EntityFrameworkCore;
using SKM.Shared.Dtos;

namespace GroupAPI.Services {
    public class GroupService : IGroupService {
        private readonly GroupDbContext _groupDbContext;

        public GroupService(GroupDbContext groupDbContext) {
            _groupDbContext = groupDbContext;
        }

      public async Task<Group> AddGroup(GroupDTO groupDTO) {
         //throw new NotImplementedException();
         var rst = await _groupDbContext.Groups.AddAsync(groupDTO.ConvertToModel());
         await _groupDbContext.SaveChangesAsync();
         return rst.Entity;
      }

      public async Task<Group> DeleteGroupAsync(int id) {
         //throw new NotImplementedException();
         var group = await _groupDbContext.Groups.FindAsync(id);
         if (group != null) {
            _groupDbContext.Groups.Remove(group);
            await _groupDbContext.SaveChangesAsync();
         }
         return group;
      }

		public async Task<List<GroupDTO>?> GetByGroupName(string groupName) {
         string strGroup = groupName.Replace("_", " ").Replace("-", "/");
         var rst = await _groupDbContext.Groups.Where(g => EF.Functions.Like(g.GroupDesc, $"%{strGroup}%")).ToListAsync();
         return (List<GroupDTO>?)rst.ConvertToDtO();
		}

		public async Task<Group> GetGroupById(int id) {
         //throw new NotImplementedException();
         //return await _groupDbContext.Groups.FindAsync(id);
         return await _groupDbContext.Groups.FindAsync(id);
        }

        public async Task<IEnumerable<Group>> GetGroups() {
         //throw new NotImplementedException();
         return await _groupDbContext.Groups.ToListAsync();
        }

      public async Task<Group> UpdateGroupAsync(GroupDTO groupDTO) {
         //throw new NotImplementedException();
         var rst = _groupDbContext.Groups.Update(groupDTO.ConvertToModel());
         await _groupDbContext.SaveChangesAsync();
         return rst.Entity;
      }
   }
}
