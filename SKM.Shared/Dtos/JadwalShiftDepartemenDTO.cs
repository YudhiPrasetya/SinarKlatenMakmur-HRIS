using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKM.Shared.Dtos {
	public class JadwalShiftDepartemenDTO {
		public int Id { get; set; }
		public string Keterangan { get; set; }
		public string GrupKerja { get; set; }
		public TimeSpan? JadwalMasuk { get; set; }
		public TimeSpan? JadwalPulang { get; set; }
	}
}
