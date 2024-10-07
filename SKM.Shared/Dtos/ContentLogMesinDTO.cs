using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKM.Shared.Dtos {
   public class ContentLogMesinDTO {
      public string? IpAddress { get; set; }
      public int Port {  get; set; }
      public int NoMesin { get; set; }
      public DateTime StartDate { get; set; }
      public DateTime EndDate { get; set; }
      public List<LogMesinAbsenDTO>? ListLogMesinAbsen { get; set; }

      //public ContentLogMesinDTO() { 
      //   ListLogMesinAbsenDTO = new List<LogMesinAbsenDTO> ();
      //}
   }
}
