using ShiftAPI.Models;
using SKM.Shared.Dtos;

namespace ShiftAPI.Conversions {
	public static class JadwalShiftDepartemenConversions {
		public static IEnumerable<JadwalShiftDepartemenDTO> ConvertToDTO(this IEnumerable<JadwalShiftDepartemen> jadwalShiftDepartemens) {
			return (
				from jadwal in jadwalShiftDepartemens select new JadwalShiftDepartemenDTO {
					Id = jadwal.Id,
					Keterangan = jadwal.Keterangan,
					GrupKerja = jadwal.GrupKerja,
					JadwalMasuk = jadwal.JadwalMasuk,
					JadwalPulang = jadwal.JadwalPulang
				}
			).ToList();
		}

		public static JadwalShiftDepartemenDTO ConvertToDTO(this JadwalShiftDepartemen jadwal) {
			return new JadwalShiftDepartemenDTO {
				Id = jadwal.Id,
				Keterangan = jadwal.Keterangan,
				GrupKerja = jadwal.GrupKerja,
				JadwalMasuk = jadwal.JadwalMasuk,
				JadwalPulang = jadwal.JadwalPulang
			};
		}

		public static IEnumerable<JadwalShiftDepartemen> ConvertToModel(this IEnumerable<JadwalShiftDepartemenDTO> jadwalShiftDepartemenDTOs) {
			return (
				from jadwal in jadwalShiftDepartemenDTOs
				select new JadwalShiftDepartemen {
					Id = jadwal.Id,
					Keterangan = jadwal.Keterangan,
					GrupKerja = jadwal.GrupKerja,
					JadwalMasuk = jadwal.JadwalMasuk,
					JadwalPulang = jadwal.JadwalPulang
				}
			).ToList();
		}

		public static JadwalShiftDepartemen ConvertToModel(this JadwalShiftDepartemenDTO jadwal) {
			return new JadwalShiftDepartemen {
				Id = jadwal.Id,
				Keterangan = jadwal.Keterangan,
				GrupKerja = jadwal.GrupKerja,
				JadwalMasuk = jadwal.JadwalMasuk,
				JadwalPulang = jadwal.JadwalPulang
			};
		}
	}
}
