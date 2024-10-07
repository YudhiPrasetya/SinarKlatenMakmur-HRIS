using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKM.Shared.Dtos {
   public class AbsenRealTimeDTO {
      public int Id { get; set; }
      public string NIK { get; set; }
      public string Nama { get; set; }
      public bool Gender { get; set; }
      public string GroupKerja { get; set; }
      public DateTime Tanggal { get; set; }
      public string IpMesin { get; set; }
      public int Port { get; set; }
      public int NoMesin { get; set; }
   }
}
