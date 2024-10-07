using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS_MesinAbsen {
   public class MesinAbsen {
      public int DeviceID { get; set; }
      public int DeviceNo { get; set; }
      public string DeviceDesc { get; set; }
      public string DeviceIP { get; set; }
      public int Port { get; set; }
      public bool IsActive { get; set; }
   }
}
