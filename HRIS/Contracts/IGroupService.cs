using SKM.Shared.Dtos;

namespace HRIS.Contracts {
   public interface IGroupService {
      Task<List<GroupDTO>> GetListGroupsAsync();
      Task<GroupDTO> GetGroupAsync(int id);
      Task<GroupDTO> AddGroupAsync(GroupDTO groupDTO);
      Task<GroupDTO> DeleteGroupAsync(int id);
      Task<GroupDTO> UpdateGroup(GroupDTO groupDTO);
      Task<List<GroupDTO>?> GetByGroupName(string groupName);
   }
}
