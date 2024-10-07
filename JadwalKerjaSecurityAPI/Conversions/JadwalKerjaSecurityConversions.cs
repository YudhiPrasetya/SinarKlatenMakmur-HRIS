using JadwalKerjaSecurityAPI.Model;
using SKM.Shared.Dtos;

namespace JadwalKerjaSecurityAPI.Conversions {
	public static class JadwalKerjaSecurityConversions {
		public static IEnumerable<JadwalKerjaSecurityDTO> ConvertToDTO(this IEnumerable<JadwalKerjaSecurity> jadwalKerjaSecurities) {
			return (
				from j in jadwalKerjaSecurities
				select new JadwalKerjaSecurityDTO {
					Id = j.Id,
					//GrupKerja = j.GrupKerja,
					NIK = j.NIK,
					Nama = j.Nama,
					Gender = j.Gender,
					Tgl = j.Tgl,
					Shift = j.Shift,
					Inisial_Shift = j.Inisial_Shift,
					JadwalMasuk = j.JadwalMasuk,
					JadwalPulang = j.JadwalPulang,
					CreatedAt = j.CreatedAt,
					CreatedBy = j.CreatedBy,
					UpdatedAt = j.UpdatedAt,
					UpdatedBy = j.UpdatedBy
				}
			).ToList();
		}

		public static JadwalKerjaSecurityDTO ConvertToDTO(this JadwalKerjaSecurity j) {
			return new JadwalKerjaSecurityDTO {
				Id = j.Id,
				//GrupKerja = j.GrupKerja,
				NIK = j.NIK,
				Nama = j.Nama,
				Gender = j.Gender,
				Tgl = j.Tgl,
				Shift = j.Shift,
				Inisial_Shift = j.Inisial_Shift,
				JadwalMasuk = j.JadwalMasuk,
				JadwalPulang = j.JadwalPulang,
				CreatedAt = j.CreatedAt,
				CreatedBy = j.CreatedBy,
				UpdatedAt = j.UpdatedAt,
				UpdatedBy = j.UpdatedBy
			};
		}

		public static IEnumerable<JadwalKerjaSecurity> ConvertToModel(this IEnumerable<JadwalKerjaSecurityDTO> jadwalKerjaSecurityDTOs) {
			return (
				from j in jadwalKerjaSecurityDTOs
				select new JadwalKerjaSecurity {
					Id = j.Id,
					//GrupKerja = j.GrupKerja,
					NIK = j.NIK,
					Nama = j.Nama,
					Gender = j.Gender,
					Tgl = j.Tgl,
					Shift = j.Shift,
					Inisial_Shift = j.Inisial_Shift,
					JadwalMasuk = j.JadwalMasuk,
					JadwalPulang = j.JadwalPulang,
					CreatedAt = j.CreatedAt,
					CreatedBy = j.CreatedBy,
					UpdatedAt = j.UpdatedAt,
					UpdatedBy = j.UpdatedBy
				}
			).ToList();
		}

		public static JadwalKerjaSecurity ConvertToModel(this JadwalKerjaSecurityDTO j) {
			return new JadwalKerjaSecurity {
				Id = j.Id,
				//GrupKerja = j.GrupKerja,
				NIK = j.NIK,
				Nama = j.Nama,
				Gender = j.Gender,
				Tgl = j.Tgl,
				Shift = j.Shift,
				Inisial_Shift = j.Inisial_Shift,
				JadwalMasuk = j.JadwalMasuk,
				JadwalPulang = j.JadwalPulang,
				CreatedAt = j.CreatedAt,
				CreatedBy = j.CreatedBy,
				UpdatedAt = j.UpdatedAt,
				UpdatedBy = j.UpdatedBy
			};
		}
	}
}
