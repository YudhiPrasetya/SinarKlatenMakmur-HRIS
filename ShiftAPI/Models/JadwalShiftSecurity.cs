namespace ShiftAPI.Models {
	public class JadwalShiftSecurity {
		public int Id { get; set; }
		public string Deskripsi { get; set; }
		public TimeSpan? JadwalMasuk { get; set; }
		public TimeSpan? JadwalPulang { get; set; }
		public string? Initial { get; set; }
	}
}
