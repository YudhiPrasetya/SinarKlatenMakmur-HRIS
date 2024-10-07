using SKM.Shared.Dtos;

namespace HRIS.Contracts {
	public interface IPTKPService {
		Task<IEnumerable<PenghasilanTidakKenaPajakDTO>> GetPTKPAsync();
	}
}
