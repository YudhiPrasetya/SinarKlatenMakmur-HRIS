using System.ComponentModel.DataAnnotations.Schema;

namespace GajiDanTunjanganAPI.Model {
	public class GajiDanTunjangan {
		public int Id { get; set; }
		public int? GroupId { get; set; }
		public string? GrupKerja { get; set; }
		public int? EmployeeId { get; set; }
		public string? NIK { get; set; }
		public string? NamaKaryawan { get; set; }
		public int? DepartmentId { get; set; }
		public string? DepartmentName { get; set; }
		public decimal? Upah { get; set; }
		public string? PTKP { get; set; }
		public int? PTKP_Jumlah { get; set; }
		public int? TunjJabatan { get; set; }
		public int? TunjKeterampilan { get; set; }
		public int? TunjMasaKerja { get; set; }
		public int? TunjLain { get; set; }
		public int? PotonganKoperasi { get; set; }
		public int? PotonganLain { get; set; }
		public string? Potong_BPJSKes { get; set; }
		public string? Potong_BPJSTK { get; set; }

		[Column(TypeName = "decimal(5,2)")]
		public decimal? BPJS_Ortu1 { get; set; }

		[Column(TypeName = "decimal(5,2)")]
		public decimal? BPJS_Ortu2 { get; set; }

		[Column(TypeName = "decimal(5,2)")]
		public decimal? BPJS_Ortu3 { get; set; }

		[Column(TypeName = "decimal(5,2)")]
		public decimal? BPJS_Ortu4 { get; set; }
		public int? CreatedBy { get; set; } = 1;
		public DateTime? CreatedAt { get; set; } = DateTime.Now;
		public int? UpdatedBy { get; set; } = 1;
		public DateTime? UpdatedAt { get; set; } = DateTime.Now;
	}
}
