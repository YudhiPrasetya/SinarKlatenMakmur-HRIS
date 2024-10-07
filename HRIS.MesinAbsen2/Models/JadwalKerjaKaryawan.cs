using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.MesinAbsen2.Models {
	public class JadwalKerjaKaryawan {
		public int Id { get; set; }
		public string NIK { get; set; }
		public string NamaKaryawan { get; set; }
		public bool? Gender { get; set; }
		public string GroupName { get; set; }
		//public DateTime? TglAwal { get; set; }
		//public DateTime? TglAkhir { get; set; }
		public DateTime? Tgl { get; set; }
		public string Shift { get; set; }
		public TimeSpan? JamMasuk { get; set; }
		public TimeSpan? JamPulang { get; set; }
		public string Keterangan { get; set; }
		public int CreatedBy { get; set; }
		public DateTime? CreatedAt { get; set; }
		public int UpdatedBy { get; set; }
		public DateTime? UpdatedAt { get; set; }
	}
}
