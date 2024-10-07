using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKM.Shared.Dtos {
   public class SPLDetailDTO {
      public int Id { get; set; }
      public int? LemburKe { get; set; }
      public decimal? NominalLembur { get; set; }

      public int SPLId { get; set; }
      public int SuratPerintahLemburId { get; set; }
   }
}
