namespace KehadiranAPI.Classes {
	public class ContentLogMesinAbsen {
		public string IpAddress { get; set; }
		public int Port { get; set; }
		public int NoMesin { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }

		public List<LogMesinAbsen>? ListLogMesinAbsen { get; set; }

	}

    public class LogMesinAbsen
    {
      public string? IPMesin { get; set; }
		public int PortMesin { get; set; }
		public int NoMesin { get; set; }
		public string? NIK { get; set; }
		public DateTime Tgl { get; set; }
	}
}
