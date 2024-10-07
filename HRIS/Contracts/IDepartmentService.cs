using SKM.Shared.Dtos;

namespace HRIS.Contracts
{
	public interface IDepartmentService
	{
		Task<List<DepartmentDTO>> GetListDepartmentsAsync();
		Task<DepartmentDTO> GetDepartmentAsync(int id);
		Task<DepartmentDTO> AddDepartmentAsync(DepartmentDTO departmentDTO);
		Task<DepartmentDTO> DeleteDepartmentAsync(int id);
		Task<DepartmentDTO> UpdateDepartmentAsync(DepartmentDTO departmentDTO);
		Task<bool> SendDepartmentOffer(DepartmentDTO departmentDTO);
	}
}
