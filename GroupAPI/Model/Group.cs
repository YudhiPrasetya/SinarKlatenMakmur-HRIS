using System.ComponentModel;

namespace GroupAPI.Model {
    public class Group {
      [DefaultValue(0)]
      public int GroupID { get; set; }
      public string GroupDesc { get; set; }

      [DefaultValue(true)]
      public bool IsActive { get; set; }
      public DateTime CreatedAt { get; set; } = DateTime.Now;

      [DefaultValue(1)]
      public int CreatedBy { get; set; }
      public DateTime UpdatedAt { get; set; } = DateTime.Now;
      public int UpdatedBy { get; set; } = 1;
    }
}
