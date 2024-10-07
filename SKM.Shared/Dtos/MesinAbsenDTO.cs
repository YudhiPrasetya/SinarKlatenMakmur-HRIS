using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKM.Shared.Dtos {
   public class MesinAbsenDTO {
      public int DeviceID { get; set; }
      public int? DeviceNo { get; set; }
      public string DeviceDesc { get; set; }
      public string DeviceIP { get; set; }
      public int Port { get; set; }
      public bool IsActive { get; set; }
      public DateTime CreatedAt { get; set; } = DateTime.Now;
      public int CreatedBy { get; set; } = 1;
      public DateTime UpdatedAt { get; set; } = DateTime.Now;
      public int UpdatedBy { get; set; } = 1;
   }
}
