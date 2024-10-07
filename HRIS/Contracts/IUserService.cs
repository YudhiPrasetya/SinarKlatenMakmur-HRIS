using SKM.Shared.Dtos;

namespace HRIS.Contracts
{
  public interface IUserService
  {
      //Task<IEnumerable<UserDTO>> GetUsers();
    Task<HttpResponseMessage?> GetUsers();
    Task<UserDTO> GetUser(int id);
    Task<UserDTO> AddUser(UserDTO UserDTO);
    Task<UserDTO> DeleteUser(int id);
  }
}
