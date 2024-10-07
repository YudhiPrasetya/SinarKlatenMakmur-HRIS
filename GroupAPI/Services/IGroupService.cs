using GroupAPI.Model;
using SKM.Shared.Dtos;

namespace GroupAPI.Services {
    public interface IGroupService {
      Task<IEnumerable<Group>> GetGroups();
      Task<Group> GetGroupById(int id);
      Task<Group> AddGroup(GroupDTO groupDTO);
      Task<Group> UpdateGroupAsync(GroupDTO groupDTO);
      Task<Group> DeleteGroupAsync(int id);
      Task<List<GroupDTO>?> GetByGroupName(string groupName);
   }
}
