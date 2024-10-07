using SKM.Shared.Dtos;

namespace HRIS.Contracts {
	public interface IJamKerjaService {
		Task<JamKerjaDTO> GetJamKerja(int id);
		Task<JamKerjaDTO> AddJamKerja(JamKerjaDTO jamKerjaDTO);
		Task<JamKerjaDTO> UpdateJamKerja(JamKerjaDTO jamKerjaDTO);
	}
}
