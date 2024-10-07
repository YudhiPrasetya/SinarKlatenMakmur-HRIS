namespace PositionAPI.Models
{
	public class Position
	{
		public int PositionId { get; set; }
		public string PositionDesc { get; set; }
		public bool IsActive { get; set; } = true;
		public DateTime CreatedAt { get; set; } = DateTime.Now;
		public int CreatedBy { get; set; } = 1;
		public DateTime UpdatedAt { get; set; } = DateTime.Now;
		public int UpdatedBy { get; set; } = 1;
    }
}
