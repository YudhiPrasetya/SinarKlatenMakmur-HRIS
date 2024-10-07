using JadwalKerjaKaryawanAPI.Model;
using SKM.Shared.Dtos;

namespace JadwalKerjaKaryawanAPI.Conversions {
   public static class JadwalKerjaKaryawanConversions {
      public static IEnumerable<JadwalKerjaKaryawanDTO> ConvertToDTO(this IEnumerable<JadwalKerjaKaryawan> jadwals) {
         return (from j in jadwals
                 select new JadwalKerjaKaryawanDTO {
                    Id = j.Id,
                    NIK = j.NIK,
                    NamaKaryawan = j.NamaKaryawan,
                    Gender = j.Gender,
                    GroupName = j.GroupName,
                    //TglAwal = j.TglAwal,
                    //TglAkhir = j.TglAkhir,
                    Tgl = j.Tgl,
                    Shift = j.Shift,
                    JamMasuk = j.JamMasuk,
                    JamPulang = j.JamPulang,
                    Keterangan = j.Keterangan,
                    CreatedAt = j.CreatedAt,
                    CreatedBy = j.CreatedBy,
                    UpdatedAt = j.UpdatedAt,
                    UpdatedBy = j.UpdatedBy
                 }).ToList<JadwalKerjaKaryawanDTO>();
      }

      public static JadwalKerjaKaryawanDTO ConvertToDTO(this JadwalKerjaKaryawan j) {
         return new JadwalKerjaKaryawanDTO {
            Id = j.Id,
            NIK = j.NIK,
            NamaKaryawan = j.NamaKaryawan,
            GroupName = j.GroupName,
            Gender = j.Gender,
            //TglAwal = j.TglAwal,
            //TglAkhir = j.TglAkhir,
            Tgl = j.Tgl,
				Shift = j.Shift,
				JamMasuk = j.JamMasuk,
            JamPulang = j.JamPulang,
            Keterangan = j.Keterangan,
            CreatedAt = j.CreatedAt,
            CreatedBy = j.CreatedBy,
            UpdatedAt = j.UpdatedAt,
            UpdatedBy = j.UpdatedBy
         };
      }

      public static IEnumerable<JadwalKerjaKaryawan> ConvertToModel(this IEnumerable<JadwalKerjaKaryawanDTO> jadwalDTOs){
         return (from j in jadwalDTOs
                 select new JadwalKerjaKaryawan {
                    Id = j.Id,
                    NIK = j.NIK,
                    NamaKaryawan = j.NamaKaryawan,
                    Gender = j.Gender,
                    GroupName = j.GroupName,
                    //TglAwal = j.TglAwal,
                    //TglAkhir = j.TglAkhir,
                    Tgl = j.Tgl,
						  Shift = j.Shift,
						  JamMasuk = j.JamMasuk,
                    JamPulang = j.JamPulang,
                    Keterangan = j.Keterangan,
                    CreatedAt = j.CreatedAt,
                    CreatedBy = j.CreatedBy,
                    UpdatedAt = j.UpdatedAt,
                    UpdatedBy = j.UpdatedBy
                 }).ToList();
      }

      public static JadwalKerjaKaryawan ConvertToModel(this JadwalKerjaKaryawanDTO j) {
         return new JadwalKerjaKaryawan {
            Id = j.Id,
            NIK = j.NIK,
            NamaKaryawan = j.NamaKaryawan,
            Gender = j.Gender,
            GroupName = j.GroupName,
            //TglAwal = j.TglAwal,
            //TglAkhir = j.TglAkhir,
            Tgl = j.Tgl,
				Shift = j.Shift,
				JamMasuk = j.JamMasuk,
            JamPulang = j.JamPulang,
            Keterangan = j.Keterangan,
            CreatedAt = j.CreatedAt,
            CreatedBy = j.CreatedBy,
            UpdatedAt = j.UpdatedAt,
            UpdatedBy = j.UpdatedBy
         };
      }
   }
}
