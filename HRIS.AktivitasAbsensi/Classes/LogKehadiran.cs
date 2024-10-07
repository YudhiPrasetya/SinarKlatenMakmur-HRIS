using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.AktivitasAbsensi.Classes {
   public enum InOutMode {
      Check_In,
      Check_Out,
      Break_Out,
      Break_In,
      OT_In,
      OT_Out
   }

   public class LogKehadiran {
      public VerifyMode VerifyMode { get; set; }
      public string NIK { get; set; }
      public DateTime Tgl { get; set; }
      public InOutMode InOutMode { get; set; }
   }
}
