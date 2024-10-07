namespace ShiftAPI.Models {
	public class JadwalShiftKaryawan {
      public int Id { get; set; }
      public string? Deskripsi { get; set; }
      public TimeSpan? JadwalMasuk { get; set; }
      public TimeSpan? JadwalPulang { get; set; }
      public string? Days { get; set; }
      public string? Initial { get; set; }
   }
}
