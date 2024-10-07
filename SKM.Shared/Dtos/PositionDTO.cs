using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKM.Shared.Dtos {
   public class PositionDTO {
      public int PositionId { get; set; }
      public string PositionDesc { get; set; }
      public bool IsActive { get; set; }
      public DateTime CreatedAt { get; set; }
      public int CreatedBy { get; set; }
      public DateTime UpdatedAt { get; set; }
      public int UpdatedBy { get; set; }
   }
}
