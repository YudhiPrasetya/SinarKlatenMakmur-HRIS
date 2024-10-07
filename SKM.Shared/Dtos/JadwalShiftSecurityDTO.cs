using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKM.Shared.Dtos {
	public class JadwalShiftSecurityDTO {
		public int Id { get; set; }
		public string Deskripsi { get; set; }
		public TimeSpan? JadwalMasuk { get; set; }
		public TimeSpan? JadwalPulang { get; set; }
      public string? Initial { get; set; }

   }
}
