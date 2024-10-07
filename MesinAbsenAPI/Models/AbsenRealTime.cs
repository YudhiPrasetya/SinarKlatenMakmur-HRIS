namespace MesinAbsenAPI.Model {
   public class AbsenRealTime {
      public int Id { get; set; }
      public string? NIK { get; set; }
      public string? Nama { get; set; }
      public bool Gender { get; set; }
      public string? GroupKerja { get; set; }
      public DateTime Tanggal { get; set; }
      public string? IpMesin { get; set; }
      public int Port { get; set; }
      public int NoMesin { get; set; }
   }
}
