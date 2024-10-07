using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKM.Shared.Dtos {
   public class PenghasilanTidakKenaPajakDTO {
      public int Id { get; set; }
      public string? Keterangan { get; set; }
      public int Jumlah { get; set; }
      public bool IsActive { get; set; }
      public int CreatedBy { get; set; } = 1;
      public DateTime? CreatedAt { get; set; }
      public int UpdatedBy { get; set; } = 1;
      public DateTime? UpdatedAt { get; set; }

		public override bool Equals(object? obj) {
         var other = obj as PenghasilanTidakKenaPajakDTO;
         return other?.Id == Id;
			//return base.Equals(obj);
		}

      public override int GetHashCode() => Id.GetHashCode();

		public override string ToString() {
         //return base.ToString();
         return $"{Keterangan}-{Jumlah}";
		}

	}
}
