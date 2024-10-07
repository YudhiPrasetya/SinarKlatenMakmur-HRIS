namespace MesinAbsenAPI.Models {
	public class LogMesinAbsen {
		public int id { get; set; }
		public string? IPMesin { get; set; }
		public int PortMesin { get; set; }
		public int NoMesin { get; set; }
		public string? NIK { get; set; }
		public DateTime? Tgl { get; set; }
	}
}
