using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKM.Shared.Dtos {
   public class HitunganLemburDTO {
      [Key]
      public int Id { get; set; }
      public int? LemburKe { get; set; }
      public int? JumlahUang { get; set; }
      public int? SPLDetailId { get; set; }
   }
}
