using System.ComponentModel.DataAnnotations;

namespace KehadiranAPI.Model {
   public class AbsenPulang {
      public int Id { get; set; }

      public string NIK { get; set; }

      public DateTime Tanggal { get; set; }

      [DataType(DataType.Time)]
      public TimeSpan? JamPulang { get; set; }

      [DataType(DataType.Time)]
      public TimeSpan? JadwalPulang { get; set; }

   }
}
