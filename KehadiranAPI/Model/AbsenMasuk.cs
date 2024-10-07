using System.ComponentModel.DataAnnotations;

namespace KehadiranAPI.Model {

   public class AbsenMasuk {
		public int Id { get; set; }

      public string NIK { get; set; }

      public DateTime Tanggal { get; set; }

      [DataType(DataType.Time)]
      public TimeSpan? JamMasuk { get; set; }

      [DataType(DataType.Time)]
      public TimeSpan? JadwalMasuk { get; set; }

      public string? KeteranganMasuk { get; set; }

   }
}
