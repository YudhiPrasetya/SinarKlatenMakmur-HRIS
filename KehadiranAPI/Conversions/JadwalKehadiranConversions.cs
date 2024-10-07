using KehadiranAPI.Model;
using SKM.Shared.Dtos;

namespace KehadiranAPI.Conversions {
   public static class JadwalKehadiranConversions {
      public static List<JadwalKehadiranDTO> ConvertToDTO(this List<JadwalKehadiran> jadwalKehadirans) {
         return (
            from k in jadwalKehadirans select new JadwalKehadiranDTO {
               Id = k.Id,
               NIK = k.NIK,
               Nama = k.Nama,
               Gender = k.Gender,
               GrupKerja = k.GrupKerja,
               JadwalMasuk = k.JadwalMasuk,
               JadwalPulang = k.JadwalPulang,
               JamMasuk = k.JamMasuk,
               JamPulang = k.JamPulang,
               Terlambat = k.Terlambat,
               Keterangan = k.Keterangan,
               LockedMasuk = k.LockedMasuk,
               LockedPulang = k.LockedPulang,
               Shift = k.Shift,
               Inisial_Shift = k.Inisial_Shift,
               AlasanTerlambat = k.AlasanTerlambat,
               Status = k.Status,
               Up = k.Up,
					IdJadwalShiftKaryawan = k.IdJadwalShiftKaryawan
				}
         ).ToList();
      }

      public static JadwalKehadiranDTO ConvertToDTO(this JadwalKehadiran k) {
         return new JadwalKehadiranDTO {
            Id = k.Id,
            NIK = k.NIK,
            Nama = k.Nama,
            Gender = k.Gender,
            GrupKerja = k.GrupKerja,
            JadwalMasuk = k.JadwalMasuk,
            JadwalPulang = k.JadwalPulang,
            JamMasuk = k.JamMasuk,
            JamPulang = k.JamPulang,
            Terlambat = k.Terlambat,
            Keterangan = k.Keterangan,
            LockedMasuk = k.LockedMasuk,
            LockedPulang = k.LockedPulang,
            Shift = k.Shift,
            Inisial_Shift = k.Inisial_Shift,
				AlasanTerlambat = k.AlasanTerlambat,
				Status = k.Status,
            Up = k.Up,
				IdJadwalShiftKaryawan = k.IdJadwalShiftKaryawan
			};
      }

      public static List<JadwalKehadiran> ConvertToModel(this List<JadwalKehadiranDTO> jadwalKehadiranDTOs) {
         return (
            from k in jadwalKehadiranDTOs
            select new JadwalKehadiran {
               Id = k.Id,
               NIK = k.NIK,
               Nama = k.Nama,
               Gender = k.Gender,
               GrupKerja = k.GrupKerja,
               JadwalMasuk = k.JadwalMasuk,
               JadwalPulang = k.JadwalPulang,
               JamMasuk = k.JamMasuk,
               JamPulang = k.JamPulang,
               Terlambat = k.Terlambat,
               Keterangan = k.Keterangan,
               LockedMasuk = k.LockedMasuk,
               LockedPulang = k.LockedPulang,
               Shift = k.Shift,
               Inisial_Shift = k.Inisial_Shift,
					AlasanTerlambat = k.AlasanTerlambat,
					Status = k.Status,
               Up = k.Up,
					IdJadwalShiftKaryawan = k.IdJadwalShiftKaryawan
				}
         ).ToList();
      }

      public static JadwalKehadiran ConvertToModel(this JadwalKehadiranDTO k) {
         return new JadwalKehadiran {
            Id = k.Id,
            NIK = k.NIK,
            Nama = k.Nama,
            Gender = k.Gender,
            GrupKerja = k.GrupKerja,
            JadwalMasuk = k.JadwalMasuk,
            JadwalPulang = k.JadwalPulang,
            JamMasuk = k.JamMasuk,
            JamPulang = k.JamPulang,
            Terlambat = k.Terlambat,
            Keterangan = k.Keterangan,
            LockedMasuk = k.LockedMasuk,
            LockedPulang = k.LockedPulang,
            Shift = k.Shift,
            Inisial_Shift = k.Inisial_Shift,
				AlasanTerlambat = k.AlasanTerlambat,
				Status = k.Status,
            Up = k.Up,
				IdJadwalShiftKaryawan = k.IdJadwalShiftKaryawan
			};
      }
   }
}
