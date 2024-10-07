using KehadiranAPI.Model;
using SKM.Shared.Dtos;

namespace KehadiranAPI.Conversions {
   public static class KehadiranConversions {
      public static IEnumerable<KehadiranDTO> ConvertToDTO(this IEnumerable<Kehadiran> kehadirans) {
         return (
            from k in kehadirans
            select new KehadiranDTO {
               Id = k.Id,
               GrupKerja = k.GrupKerja,
               Tanggal = k.Tanggal,
               NIK = k.NIK,
               Nama = k.Nama,
               Gender = k.Gender,
               JadwalMasuk = k.JadwalMasuk,
               JamMasuk = k.JamMasuk,
               Terlambat = k.Terlambat,
               Keterangan = k.Keterangan,
               JadwalPulang = k.JadwalPulang,
               JamPulang = k.JamPulang,
               AlasanTerlambat = k.AlasanTerlambat
            }
         ).ToList();
      }

      public static KehadiranDTO ConvertToDTO(this Kehadiran k) {
         return new KehadiranDTO {
            Id = k.Id,
            GrupKerja = k.GrupKerja,
            Tanggal = k.Tanggal,
            NIK = k.NIK,
            Nama = k.Nama,
            Gender = k.Gender,
            JadwalMasuk = k.JadwalMasuk,
            JamMasuk = k.JamMasuk,
            Terlambat = k.Terlambat,
            Keterangan = k.Keterangan,
            JadwalPulang = k.JadwalPulang,
            JamPulang = k.JamPulang,
            AlasanTerlambat = k.AlasanTerlambat
         };
      }

      public static IEnumerable<Kehadiran> ConvertToModel(this IEnumerable<KehadiranDTO> kehadiranDTOs) {
         return (
            from k in kehadiranDTOs
            select new Kehadiran {
               Id = k.Id,
               GrupKerja = k.GrupKerja,
               Tanggal = k.Tanggal,
               NIK = k.NIK,
               Nama = k.Nama,
               Gender = k.Gender,
               JadwalMasuk = k.JadwalMasuk,
               JamMasuk = k.JamMasuk,
               Terlambat = k.Terlambat,
               Keterangan = k.Keterangan,
               JadwalPulang = k.JadwalPulang,
               JamPulang = k.JamPulang,
               AlasanTerlambat = k.AlasanTerlambat
            }
         ).ToList();
      }

      public static Kehadiran ConvertToModel(this KehadiranDTO k) {
         return new Kehadiran {
            Id = k.Id,
            GrupKerja = k.GrupKerja,
            Tanggal = k.Tanggal,
            NIK = k.NIK,
            Nama = k.Nama,
            Gender = k.Gender,
            JadwalMasuk = k.JadwalMasuk,
            JamMasuk = k.JamMasuk,
            Terlambat = k.Terlambat,
            Keterangan = k.Keterangan,
            JadwalPulang = k.JadwalPulang,
            JamPulang = k.JamPulang,
            AlasanTerlambat = k.AlasanTerlambat
         };
      }
   //   public static IEnumerable<AbsenMasukDTO> ConvertToDtO(this IEnumerable<AbsenMasuk> absenMasuks) {
   //      return (from k in absenMasuks
   //              select new AbsenMasukDTO {
   //                  Id = k.Id,
   //                  NIK = k.NIK,
   //                  Tanggal = k.Tanggal,
   //                  JamMasuk = k.JamMasuk,
			//			  JadwalMasuk = k.JadwalMasuk,
			//			  KeteranganMasuk = k.KeteranganMasuk
			//		  }).ToList();
   //   }

   //   public static AbsenMasukDTO ConvertToDTO(this AbsenMasuk k) {
   //      return new AbsenMasukDTO {
   //         Id = k.Id,
   //         NIK = k.NIK,
   //         Tanggal = k.Tanggal,
   //         JamMasuk = k.JamMasuk,
   //         JadwalMasuk = k.JadwalMasuk,
   //         KeteranganMasuk = k.KeteranganMasuk
   //      };
   //   }

   //   public static IEnumerable<AbsenMasuk> ConvertToModel(this IEnumerable<AbsenMasukDTO> absenMasukDTOs) {
   //      return (from absenMasukDTO in absenMasukDTOs
   //              select new AbsenMasuk {
   //                 Id = absenMasukDTO.Id,
   //                 NIK = absenMasukDTO.NIK,
   //                 Tanggal = absenMasukDTO.Tanggal,
   //                 JamMasuk = absenMasukDTO.JamMasuk,
			//			  JadwalMasuk = absenMasukDTO.JadwalMasuk,
			//			  KeteranganMasuk = absenMasukDTO.KeteranganMasuk
			//		  }).ToList();
   //   }

   //   public static AbsenMasuk ConvertToModel(this AbsenMasukDTO absenMasukDTO) {
   //      return new AbsenMasuk {
   //         Id = absenMasukDTO.Id,
   //         NIK = absenMasukDTO.NIK,
   //         Tanggal = absenMasukDTO.Tanggal,
   //         JamMasuk = absenMasukDTO.JamMasuk,
			//	JadwalMasuk = absenMasukDTO.JadwalMasuk,
			//	KeteranganMasuk = absenMasukDTO.KeteranganMasuk
			//};
   //   }

   }
}
