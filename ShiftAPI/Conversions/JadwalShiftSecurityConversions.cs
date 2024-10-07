using ShiftAPI.Models;
using SKM.Shared.Dtos;
using System.Runtime.CompilerServices;

namespace ShiftAPI.Conversions {
	public static class JadwalShiftSecurityConversions {
		public static IEnumerable<JadwalShiftSecurityDTO> ConvertToDTO(this IEnumerable<JadwalShiftSecurity> jadwalShiftSecurities) {
			return (
				from j in jadwalShiftSecurities select new JadwalShiftSecurityDTO {
					Id = j.Id,
					Deskripsi = j.Deskripsi,
					JadwalMasuk = j.JadwalMasuk,
					JadwalPulang = j.JadwalPulang,
					Initial = j.Initial
				}
			).ToList();
		}

		public static JadwalShiftSecurityDTO ConvertToDTO(this JadwalShiftSecurity j) {
			return new JadwalShiftSecurityDTO {
				Id = j.Id,
				Deskripsi = j.Deskripsi,
				JadwalMasuk = j.JadwalMasuk,
				JadwalPulang = j.JadwalPulang,
				Initial = j.Initial
			};
		}

		public static IEnumerable<JadwalShiftSecurity> ConvertToModel(this IEnumerable<JadwalShiftSecurityDTO> jadwalShiftSecurityDTOs) {
			return (
				from j in jadwalShiftSecurityDTOs
				select new JadwalShiftSecurity {
					Id = j.Id,
					Deskripsi = j.Deskripsi,
					JadwalMasuk = j.JadwalMasuk,
					JadwalPulang = j.JadwalPulang,
					Initial = j.Initial
				}
			).ToList();
		}

		public static JadwalShiftSecurity ConvertToModel(this JadwalShiftSecurityDTO j) {
			return new JadwalShiftSecurity {
				Id = j.Id,
				Deskripsi = j.Deskripsi,
				JadwalMasuk = j.JadwalMasuk,
				JadwalPulang = j.JadwalPulang,
				Initial = j.Initial
			};
		}
	}
	
}
