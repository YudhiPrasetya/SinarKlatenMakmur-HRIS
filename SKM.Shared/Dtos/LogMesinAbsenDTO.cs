using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKM.Shared.Dtos {
	public class LogMesinAbsenDTO {
		//public int id { get; set; }
		public string? IPMesin { get; set; }
		public int PortMesin { get; set; }
		public int NoMesin { get; set; }
		public string? NIK { get; set; }
		public DateTime? Tgl { get; set; }
		
	}
}
