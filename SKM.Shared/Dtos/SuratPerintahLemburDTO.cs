using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKM.Shared.Dtos {
   public class SuratPerintahLemburDTO {
      public bool ShowDetails { get; set; } = false;
      public int Id { get; set; }
      public int? GroupId { get; set; }
      public string? GroupName { get; set; }
      public int? DepartmentId { get; set; }
      public string? DepartmentName { get; set; }
      public int? EmployeeId { get; set; }
      public string? EmployeeName { get; set; }
      public string? NIK { get; set; }
      public string? Description { get; set; }
      public string? Style { get; set; }
      public string? OTType { get; set; }
      public DateTime? OTDate { get; set; }
      public int? OT1 { get; set; }
      public decimal? NominalOT1 { get; set; }
      public int? OT2 { get; set; }
      public decimal? NominalOT2 { get; set; }
		public decimal? NominalOT3 { get; set; }
		public decimal? NominalOT4 { get; set; }
		public int? OTBreak { get; set; }
      public int? OTTotal { get; set; }
      public decimal? NominalOTTotal { get; set; }
      public decimal? Upah { get; set; }
      public int? TunjJabatan { get; set; }
      public int? TunjKeterampilan { get; set; }
      public int? TunjMasaKerja { get; set; }
      public int? TunjLain { get; set; }
      public int? OTP1 { get; set; }
      public int? OTP2 { get; set; }
      public int? OTP3 { get; set; }
      public int? OTP4 { get; set; }

      public decimal? OTPNominal1 { get; set; }
      public decimal? OTPNominal2 { get; set; }
      public decimal? OTPNominal3 { get; set; }
      public decimal? OTPNominal4 { get; set; }
      public int? CreatedBy { get; set; }
      public DateTime? CreatedAt { get; set; }
      public int? UpdatedBy { get; set; }
      public DateTime? UpdatedAT { get; set; }

   }


}
