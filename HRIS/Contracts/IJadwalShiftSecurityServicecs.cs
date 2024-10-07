using SKM.Shared.Dtos;

namespace HRIS.Contracts {
	public interface IJadwalShiftSecurityServicecs {
		Task<List<JadwalShiftSecurityDTO>> GetJadwalShiftSecurityAsync();
		Task<JadwalShiftSecurityDTO> AddJadwalShiftSecurity(JadwalShiftSecurityDTO dto);
		Task<JadwalShiftSecurityDTO> UpdateJadwalShiftSecurity(JadwalShiftSecurityDTO dto);
		Task<JadwalShiftSecurityDTO?> GetByInisialAsync(string inisial);
	}
}
