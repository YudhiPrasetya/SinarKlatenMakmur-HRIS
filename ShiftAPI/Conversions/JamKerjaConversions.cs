using ShiftAPI.Models;
using SKM.Shared.Dtos;

namespace ShiftAPI.Conversions {
	public static class JamKerjaConversions {
		public static JamKerjaDTO ConvertToDTO(this JamKerja j) {
			return new JamKerjaDTO {
				Id = j.Id,
				Deskripsi = j.Deskripsi,
				DurasiPerHari = j.DurasiPerHari,
				PembagiPayroll = j.PembagiPayroll
			};
		}

		public static JamKerja ConvertToModel(this JamKerjaDTO j) {
			return new JamKerja {
				Id = j.Id,
				Deskripsi = j.Deskripsi,
				DurasiPerHari = j.DurasiPerHari,
            PembagiPayroll = j.PembagiPayroll
         };
		}
	}
}
