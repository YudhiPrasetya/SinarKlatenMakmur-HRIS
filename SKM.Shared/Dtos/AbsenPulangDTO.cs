using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKM.Shared.Dtos {
   public class AbsenPulangDTO {
      public int Id { get; set; }
      public string NIK { get; set; }
      public DateTime Tanggal { get; set; }
      public TimeSpan? JamPulang { get; set; }

      [DataType(DataType.Time)]
      public TimeSpan? JadwalPulang { get; set; }
   }
}
