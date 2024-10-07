using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKM.Shared.Dtos {
    public class GroupDTO {
      public int GroupID { get; set; }
      public string GroupDesc { get; set; }
      public bool IsActive { get; set; }
      public DateTime CreatedAt { get; set; }
      public int CreatedBy { get; set; }
      public DateTime UpdatedAt { get; set; }
      public int UpdatedBy { get; set; }

      public override bool Equals(object? obj) {
         var other = obj as GroupDTO;
         return other?.GroupID == GroupID;
         //return base.Equals(obj);
      }

      public override int GetHashCode() => GroupID.GetHashCode();

      public override string ToString() {
         return GroupDesc;
      }
    }
}
