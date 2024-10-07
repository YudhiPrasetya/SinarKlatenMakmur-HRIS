namespace ShiftAPI.Models {
	public class JadwalShiftDepartemen {
		public int Id { get; set; }
		public string Keterangan { get; set; }
		public string GrupKerja { get; set; }
		public TimeSpan? JadwalMasuk { get; set; }
		public TimeSpan? JadwalPulang { get; set; }

	}
}
