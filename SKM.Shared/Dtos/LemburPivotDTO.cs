using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKM.Shared.Dtos {
   public class LemburPivotDTO {
      public string GrupKerja { get; set; }
      public string NIK { get; set; }
      public string Nama { get; set; }
      public DateTime? Tanggal { get; set; }
      public string JenisLembur { get; set; }
      public int Ke1 {get; set;}
      public int Ke2 {get; set;}
      public int Ke3 {get; set;}
      public int Ke4 {get; set;}
      public int Ke5 {get; set;}
      public int Ke6 {get; set;}
      public int Ke7 {get; set;}
      public int Ke8 {get; set;}
      public int Total {get; set;}
   }
}
