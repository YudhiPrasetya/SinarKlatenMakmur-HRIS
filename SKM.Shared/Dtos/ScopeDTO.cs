using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKM.Shared.Dtos {
   public class ScopeDTO {
      public int ScopeId { get; set; }
      public string? GroupIcon { get; set; }
      public string? GroupTitle { get; set; }
      public string? MenuIcon { get; set; }
      public string? MenuTitle { get; set; }
      public string? Route { get; set; }
      public string? Scope { get; set; }
   }
}
