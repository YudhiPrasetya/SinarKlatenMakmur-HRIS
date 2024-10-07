using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKM.Shared.Dtos {
   public class PayrollPreviewDTO {
      public string? Nama { get; set; }
      public string? NIK { get; set; }
      public string? GrupKerja { get; set; }
      public string? NoKTP { get; set; }
      public string? NoBPJSTK { get; set; }
      public string? NoBPJSKS { get; set; }
      public string? Alamat { get; set; }
      public string? Gender { get; set; }
      public string? NoRek { get; set; }

      public string? Periode { get; set; }
      public string? TglCetak { get; set; }
      public decimal? Upah { get; set; }
      public decimal? JmlUpah { get; set; }
      public int? Hadir { get; set; }
      public int? TidakHadir { get; set; }
      public decimal? TidakHadirNominal { get; set; }
      public int? TunjKeterampilan { get; set; }
      public int? TunjJabatan { get; set; }
      public int? TunjMasaKerja { get; set; }
      public int? TunjLain2 { get; set; }
      public int? JamLemburKe1 { get; set; }

      public int? JamLemburKe2 { get; set; }

      public int? JamLemburKe3 { get; set; }

      [DefaultValue(0)]
      public int? JamLemburKe4 { get; set; }

      public decimal? NominalLemburKe1 { get; set; }

      public decimal? NominalLemburKe2 { get; set; }

      public decimal? NominalLemburKe3 { get; set; }

      public decimal? NominalLemburKe4 { get; set; }

      public decimal? TotalPendapatan { get; set; }

      public decimal? PotBPJSTK { get; set; }
      public decimal? PotBPJSKes { get; set; }
      public decimal? PotLain2 { get; set; }

      public decimal? TotalPotongan { get; set; }

      public decimal? TotalPenerimaan { get; set; }

      public int? SUMOTP1 { get; set; }
      public int? SUMOTP2 { get; set; }
      public int? SUMOTP3 { get; set; }
      public int? SUMOTP4 { get; set; }
      public int? SUMNominalOTP1 { get; set; }
      public int? SUMNominalOTP2 { get; set; }
      public int? SUMNominalOTP3 { get; set; }
      public int? SUMNominalOTP4 { get; set; }
      public int? OTPNominal1 { get; set; }
      public int? OTPNominal2 { get; set; }
      public int? OTPNominal3 { get; set; }
      public int? OTPNominal4 { get; set; }

      public int? TunjMakan { get; set; }
      public decimal? TunjUtility { get; set; }
      public decimal? CheckNilaiPotTdkHadir { get; set; }
      public decimal? CheckUp { get; set; }
      public int? Shift2 { get; set; }
      public int? Shift3 { get; set; }
      public decimal? AmtShift2 { get; set; }
      public decimal? AmtShift3 { get; set; }
      public int? CheckPremiShift2 { get; set; }
      public int? CheckPremiShift3 { get; set; }
      public int? OT1 { get; set; }
      public int? OT2 { get; set; }
      public int? OT3 { get; set; }
      public int? OT4 { get; set; }
      public decimal? AmtOT1 { get; set; }
      public decimal? AmtOT2 { get; set; }
      public decimal? AmtOT3 { get; set; }
      public decimal? AmtOT4 { get; set; }
      public decimal? CheckOT1 { get; set; }
      public decimal? CheckOT2 { get; set; }
      public decimal? CheckOT3 { get; set; }
      public decimal? CheckOT4 { get; set; }
      public decimal? TotSblmJMS { get; set; }
      public decimal? CheckSblmPotBPJS { get; set; }
      public decimal? CheckTotal { get; set; }

   }
}
