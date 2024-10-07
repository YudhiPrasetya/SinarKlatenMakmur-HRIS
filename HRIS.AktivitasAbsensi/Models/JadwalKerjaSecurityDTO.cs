using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.AktivitasAbsensi.Models {
	public class JadwalKerjaSecurityDTO {
		public int Id { get; set; }
		//public string GrupKerja { get; set; }
		public string NIK { get; set; }
		public string Nama { get; set; }
		public bool? Gender { get; set; }
		public DateTime Tgl { get; set; }
		public string Shift { get; set; }
		public string Inisial_Shift { get; set; }
		public TimeSpan? JadwalMasuk { get; set; }
		public TimeSpan? JadwalPulang { get; set; }
		public int? CreatedBy { get; set; }
		public DateTime? CreatedAt { get; set; }
		public int? UpdatedBy { get; set; }
		public DateTime? UpdatedAt { get; set; }
	}
}
