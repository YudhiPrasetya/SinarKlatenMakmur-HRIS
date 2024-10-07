namespace KehadiranAPI.Model {
	public class Kehadiran {
		public int Id { get; set; }
		public string? GrupKerja { get; set; }
		public DateTime? Tanggal { get; set; }	
		public string? NIK {  get; set; }
		public string? Nama { get; set; }
		public bool? Gender { get; set; }
		public TimeSpan? JadwalMasuk { get; set; }
		public TimeSpan? JamMasuk { get; set; }
		public TimeSpan? JadwalPulang { get; set; }
		public TimeSpan? JamPulang { get; set; }
		public TimeSpan? Terlambat { get; set; }
		public string? Keterangan { get; set; }
		public string? AlasanTerlambat { get; set; }
	}                                                  
}
