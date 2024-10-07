using SKM.Shared.Dtos;

namespace HRIS.Contracts {
	public interface IAbsenPulangService {
		Task<List<AbsenPulangDTO>> GetByDateRange(string? startDate, string? endDate);
	}
}
