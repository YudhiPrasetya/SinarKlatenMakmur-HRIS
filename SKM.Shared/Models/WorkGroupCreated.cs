using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKM.Shared.Models {
   public class WorkGroupCreated {
      public int GroupID { get; set; }
      public string GroupDesc { get; set; }
      public bool IsActive { get; set; }
      public DateTime CreatedAt { get; set; }
      public int CreatedBy { get; set; }
      public DateTime UpdatedAt { get; set; }
      public int UpdatedBy { get; set; }
   }
}
