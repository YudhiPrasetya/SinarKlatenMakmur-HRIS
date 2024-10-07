using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKM.Shared.Dtos {
   public class JadwalKehadiranDTO {
      public int Id { get; set; }
      public string? NIK { get; set; }
      public string? Nama { get; set; }
      public bool Gender { get; set; }
      public string? GrupKerja { get; set; }
      public DateTime? JadwalMasuk { get; set; }
      public DateTime? JadwalPulang { get; set; }
      public DateTime? JamMasuk { get; set; }
      public DateTime? JamPulang { get; set; }
      public TimeSpan? Terlambat { get; set; }
      public string? Keterangan { get; set; }
      public bool? LockedMasuk { get; set; }
      public bool? LockedPulang { get; set; }
      public string? Shift { get; set; }
      public string? Inisial_Shift { get; set; }
      public string? AlasanTerlambat { get; set; }
      public string? Status { get; set; }
      public bool? Up { get; set; }
      public int IdJadwalShiftKaryawan { get; set; }

	}
}
