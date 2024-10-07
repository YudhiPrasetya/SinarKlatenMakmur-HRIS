using SKM.Shared.Dtos;

namespace HRIS.Contracts {
	public interface IUMPService {
		Task<IEnumerable<UpahMinimumProvinsiDTO>> GetUMP();
	}
}
