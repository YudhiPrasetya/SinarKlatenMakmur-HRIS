using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKM.Shared.Dtos {
    public class DepartmentDTO {
		public int DepartmentID { get; set; }
		public string DepartmentName { get; set; }
		public string DepartmentDescription { get; set; }
      public int Budget { get; set; }
      public bool IsActive { get; set; }
		public DateTime? CreatedAt { get; set; }
		public int CreatedBy { get; set; }
		public DateTime? UpdatedAt { get; set; }
		public int UpdatedBy { get; set; }
	 }
}
