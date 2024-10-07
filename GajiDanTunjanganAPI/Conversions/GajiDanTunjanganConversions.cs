using GajiDanTunjanganAPI.Model;
using SKM.Shared.Dtos;

namespace GajiDanTunjanganAPI.Conversions {
   public static class GajiDanTunjanganConversions {
      public static IEnumerable<GajiDanTunjanganDTO> ConvertToDtO(this IEnumerable<GajiDanTunjanganAPI.Model.GajiDanTunjangan> gts) {
         return (from gt in gts
                 select new GajiDanTunjanganDTO {
                    Id = gt.Id,
                    GroupId = gt.GroupId,
                    GrupKerja = gt.GrupKerja,
                    DepartmentId = gt.DepartmentId,
                    DepartmentName = gt.DepartmentName,
                    EmployeeId = gt.EmployeeId,
                    NIK = gt.NIK,
                    NamaKaryawan = gt.NamaKaryawan,
                    Upah = gt.Upah.Value,
                    PTKP = gt.PTKP,
                    PTKP_Jumlah = gt.PTKP_Jumlah,
                    TunjJabatan = gt.TunjJabatan,
                    TunjKeterampilan = gt.TunjKeterampilan,
                    TunjMasaKerja = gt.TunjMasaKerja,
                    TunjLain = gt.TunjLain,
                    PotonganKoperasi = gt.PotonganKoperasi,
                    PotonganLain = gt.PotonganLain,
                    Potong_BPJSKes = gt.Potong_BPJSKes,
                    Potong_BPJSTK = gt.Potong_BPJSTK,
                    BPJS_Ortu1 = gt.BPJS_Ortu1,
                    BPJS_Ortu2 = gt.BPJS_Ortu2,
                    BPJS_Ortu3 = gt.BPJS_Ortu3,
                    BPJS_Ortu4 = gt.BPJS_Ortu4
                 }).ToList<GajiDanTunjanganDTO>();
      }

      public static GajiDanTunjanganDTO ConvertToDTO(this GajiDanTunjanganAPI.Model.GajiDanTunjangan gt) {
         return new GajiDanTunjanganDTO {
            Id = gt.Id,
            GroupId = gt.GroupId,
            GrupKerja = gt.GrupKerja,
            EmployeeId = gt.EmployeeId,
            NIK = gt.NIK,
            NamaKaryawan = gt.NamaKaryawan,
            DepartmentId = gt.DepartmentId,
            DepartmentName = gt.DepartmentName,
            Upah = gt.Upah.Value,
            PTKP = gt.PTKP,
            PTKP_Jumlah = gt.PTKP_Jumlah,
            TunjJabatan = gt.TunjJabatan,
            TunjKeterampilan = gt.TunjKeterampilan,
            TunjMasaKerja = gt.TunjMasaKerja,
            TunjLain = gt.TunjLain,
            PotonganKoperasi = gt.PotonganKoperasi,
            PotonganLain = gt.PotonganLain,
            Potong_BPJSKes = gt.Potong_BPJSKes,
            Potong_BPJSTK = gt.Potong_BPJSTK,
            BPJS_Ortu1 = gt.BPJS_Ortu1,
            BPJS_Ortu2 = gt.BPJS_Ortu2,
            BPJS_Ortu3 = gt.BPJS_Ortu3,
            BPJS_Ortu4 = gt.BPJS_Ortu4
         };
      }

      public static IEnumerable<GajiDanTunjanganAPI.Model.GajiDanTunjangan> ConvertToModel(this IEnumerable<GajiDanTunjanganDTO> gtDTOs) {
         return (from gtDTO in gtDTOs
                 select new GajiDanTunjanganAPI.Model.GajiDanTunjangan {
                    Id = gtDTO.Id,
                    GroupId = gtDTO.GroupId,
                    GrupKerja = gtDTO.GrupKerja,
                    EmployeeId = gtDTO.EmployeeId,
                    NIK = gtDTO.NIK,
                    NamaKaryawan = gtDTO.NamaKaryawan,
                    DepartmentId = gtDTO.DepartmentId,
                    DepartmentName = gtDTO.DepartmentName,
                    Upah = gtDTO.Upah,
                    PTKP = gtDTO.PTKP,
                    PTKP_Jumlah = gtDTO.PTKP_Jumlah,
                    TunjJabatan = gtDTO.TunjJabatan,
                    TunjKeterampilan = gtDTO.TunjKeterampilan,
                    TunjMasaKerja = gtDTO.TunjMasaKerja,
                    TunjLain = gtDTO.TunjLain,
                    PotonganKoperasi = gtDTO.PotonganKoperasi,
                    PotonganLain = gtDTO.PotonganLain,
                    Potong_BPJSKes = gtDTO.Potong_BPJSKes,
                    Potong_BPJSTK = gtDTO.Potong_BPJSTK,
                    BPJS_Ortu1 = gtDTO.BPJS_Ortu1,
                    BPJS_Ortu2 = gtDTO.BPJS_Ortu2,
                    BPJS_Ortu3 = gtDTO.BPJS_Ortu3,
                    BPJS_Ortu4 = gtDTO.BPJS_Ortu4
                 }).ToList();
      }

      public static GajiDanTunjanganAPI.Model.GajiDanTunjangan ConvertToModel(this GajiDanTunjanganDTO gtDTO) {
         return new GajiDanTunjanganAPI.Model.GajiDanTunjangan {
            Id = gtDTO.Id,
            GroupId = gtDTO.GroupId,
            GrupKerja = gtDTO.GrupKerja,
            EmployeeId = gtDTO.EmployeeId,
            NIK = gtDTO.NIK,
            NamaKaryawan = gtDTO.NamaKaryawan,
            DepartmentId = gtDTO.DepartmentId,
            DepartmentName = gtDTO.DepartmentName,
            Upah = gtDTO.Upah,
            PTKP = gtDTO.PTKP,
            PTKP_Jumlah = gtDTO.PTKP_Jumlah,
            TunjJabatan = gtDTO.TunjJabatan,
            TunjKeterampilan = gtDTO.TunjKeterampilan,
            TunjMasaKerja = gtDTO.TunjMasaKerja,
            TunjLain = gtDTO.TunjLain,
            PotonganKoperasi = gtDTO.PotonganKoperasi,
            PotonganLain = gtDTO.PotonganLain,
            Potong_BPJSKes = gtDTO.Potong_BPJSKes,
            Potong_BPJSTK = gtDTO.Potong_BPJSTK,
            BPJS_Ortu1 = gtDTO.BPJS_Ortu1,
            BPJS_Ortu2 = gtDTO.BPJS_Ortu2,
            BPJS_Ortu3 = gtDTO.BPJS_Ortu3,
            BPJS_Ortu4 = gtDTO.BPJS_Ortu4
         };
      }
   }
}
