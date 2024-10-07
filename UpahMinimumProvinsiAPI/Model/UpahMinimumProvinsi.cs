namespace UpahMinimumProvinsiAPI.Model {
   public class UpahMinimumProvinsi {
      public int Id { get; set; } = 0;
      public string? Keterangan { get; set; }
      public int Tahun { get; set; } = 0;
      public int Jumlah { get; set; } = 0;
      public int CreatedBy { get; set; } = 0;
      public int UpdatedBy { get; set; } = 0;
      public DateTime CreatedAt { get; set; } = DateTime.Now;
      public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
