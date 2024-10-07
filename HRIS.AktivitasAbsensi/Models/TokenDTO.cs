using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.AktivitasAbsensi.Models {
	public class TokenDTO {
		public string UserName { get; set; }
		public string Token { get; set; }
		public string Role { get; set; }
		public string Scopes { get; set; }
		public DateTime ExpiresIn { get; set; }
	}
}
