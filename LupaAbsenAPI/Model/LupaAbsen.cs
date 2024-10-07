namespace LupaAbsenAPI.Model {
   public class LupaAbsen {
      public int Id { get; set; }
      public DateTime? Tanggal { get; set; }
      public string NIK { get; set; }
      public string GrupKerja { get; set; }
      public string NamaKaryawan { get; set; }
      public string Absen { get; set; }
      public TimeSpan? Jam { get; set; }
      public string Keterangan { get; set; }
      public int CreatedBy { get; set; }
      public DateTime? CreatedAt { get; set; }
      public int UpdatedBy { get; set; }
      public DateTime? UpdatedAt { get; set; }
   }
}
