using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKM.Shared.Dtos {
   public class UpahMinimumProvinsiDTO {
      public int Id { get; set; }
      public string? Keterangan { get; set; }
      public int Tahun { get; set; }
      public int Jumlah { get; set; }
      public int CreatedBy { get; set; }
      public int UpdatedBy { get; set; }
      public DateTime CreatedAt { get; set; }
      public DateTime UpdatedAt { get; set; }

		public override bool Equals(object? obj) {
			//return base.Equals(obj);
         var other = obj as UpahMinimumProvinsiDTO;
         return other?.Id == Id;
		}
      public override int GetHashCode() => Id.GetHashCode();

		public override string ToString() {
         //return base.ToString();
         return Jumlah.ToString();
		}
	}
}
