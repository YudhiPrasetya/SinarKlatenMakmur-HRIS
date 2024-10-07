using SKM.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS_MesinAbsen.Contracts {
   public interface IKehadiranServicecs {
      Task<bool> AddKehadiranAsync(AbsenMasukDTO absenMasukDTO);
   }
}
