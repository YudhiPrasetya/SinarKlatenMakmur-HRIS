using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKM.Shared.Dtos {
	public class JamKerjaDTO {
		public int Id { get; set; }
		public string Deskripsi { get; set; }
		public int DurasiPerHari { get; set; }
      public int PembagiPayroll { get; set; }
   }
}
