using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.AktivitasAbsensi.Classes {
   class ContentLogMesinAbsen {
      public string IpAddress { get; set; }
      public int Port { get; set; }
      public int NoMesin { get; set; }
      public DateTime StartDate { get; set; }
      public DateTime EndDate { get; set; }

      public List<LogMesinAbsen> ListLogMesinAbsen { get; set; }

      public ContentLogMesinAbsen() {
         this.ListLogMesinAbsen = new List<LogMesinAbsen>();
      }
   }
}
