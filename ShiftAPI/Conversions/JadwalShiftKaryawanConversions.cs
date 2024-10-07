using ShiftAPI.Models;
using SKM.Shared.Dtos;

namespace ShiftAPI.Conversions {
	public static class JadwalShiftKaryawanConversions {
		public static IEnumerable<JadwalShiftKaryawanDTO> ConvertToDTO(this IEnumerable<JadwalShiftKaryawan> jadwalShiftKaryawans) {
			return (
				from k in jadwalShiftKaryawans select new JadwalShiftKaryawanDTO {
					Id = k.Id,
					Deskripsi = k.Deskripsi,
					JadwalMasuk = k.JadwalMasuk,
					JadwalPulang = k.JadwalPulang,
					Days = k.Days,
					Initial = k.Initial
				}
			).ToList();
		}

		public static JadwalShiftKaryawanDTO ConvertToDTO(this JadwalShiftKaryawan k) {
			return new JadwalShiftKaryawanDTO {
				Id = k.Id,
				Deskripsi = k.Deskripsi,
				JadwalMasuk = k.JadwalMasuk,
				JadwalPulang = k.JadwalPulang,
				Days = k.Days,
            Initial = k.Initial
         };
		}

		public static IEnumerable<JadwalShiftKaryawan> ConvertToModel(this IEnumerable<JadwalShiftKaryawanDTO> jadwalShiftKaryawanDTOs) {
			return (
				from k in jadwalShiftKaryawanDTOs
				select new JadwalShiftKaryawan {
					Id = k.Id,
					Deskripsi = k.Deskripsi,
					JadwalMasuk = k.JadwalMasuk,
					JadwalPulang = k.JadwalPulang,
					Days = k.Days,
               Initial = k.Initial
            }
			).ToList();
		}

		public static JadwalShiftKaryawan ConvertToModel(this JadwalShiftKaryawanDTO k) {
			return new JadwalShiftKaryawan {
				Id = k.Id,
				Deskripsi = k.Deskripsi,
				JadwalMasuk = k.JadwalMasuk,
				JadwalPulang = k.JadwalPulang,
				Days = k.Days,
            Initial = k.Initial
         };
		}
	}
}
