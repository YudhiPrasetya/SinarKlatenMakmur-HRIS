using SKM.Shared.Dtos;

namespace HRIS.Contracts {
   public interface IWorkGroupService {
      Task<List<GroupDTO>> GetListWorkGroupAsync();
      Task<GroupDTO> GetWorkGroupAsync(int id);
      Task<GroupDTO> AddWorkGroupAsync(GroupDTO groupDTO);
      Task<GroupDTO> DeleteWorkGroupAsync(int id);
      Task<GroupDTO> UpdateWorkGroupAsync(GroupDTO groupDTO);
   }
}
