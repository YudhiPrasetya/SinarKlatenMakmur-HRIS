namespace PenghasilanTidakKenaPajakAPI.Model {
   public class PenghasilanTidakKenaPajak {
      public int Id { get; set; } = 0;
      public string? Keterangan { get; set; }
      public int Jumlah { get; set; }
      public bool IsActive { get; set; }
      public int CreatedBy { get; set; } = 1;
      public DateTime? CreatedAt { get; set; } = DateTime.Now;
      public int UpdatedBy { get; set; } = 1;
      public DateTime? UpdatedAt { get; set; } = DateTime.Now;
    }
}
