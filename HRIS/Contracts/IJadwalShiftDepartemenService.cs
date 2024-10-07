using SKM.Shared.Dtos;

namespace HRIS.Contracts {
	public interface IJadwalShiftDepartemenService {
		Task<List<JadwalShiftDepartemenDTO>> GetJadwalShiftDepartemen();
		Task<JadwalShiftDepartemenDTO> AddJadwalShiftDepartemen(JadwalShiftDepartemenDTO jadwalShiftDepartemenDTO);
		Task<JadwalShiftDepartemenDTO> AddRange(List<JadwalShiftDepartemenDTO> jadwalShiftDepartemenDTOs);

		Task<JadwalShiftDepartemenDTO> UpdateJadwalShiftDepartemen(JadwalShiftDepartemenDTO jadwalShiftDepartemenDTO);
	}
}
