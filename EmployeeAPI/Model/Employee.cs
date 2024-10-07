using System.ComponentModel;

namespace EmployeeAPI.Model
{
	public enum Gender { Male, Female}
	public enum Married_Status { N, F, T}
	public enum Employee_Status { Contract, NonContract}
	public class Employee
	{
		public int EmployeeId { get; set; }
		public string? NIK { get; set; }
		public string? Name { get; set; }
		public int? DepartmentId { get; set; }
		public string DepartmentName { get; set; }
		public int? PositionId { get; set; }
		public string? PositionName { get; set; }
		public int? GroupID { get; set; }
		public string? GroupName { get; set; }

		public string? Pendidikan { get; set; }
		public bool Gender { get; set; }

      public string? LocBirth { get; set; }
		public DateTime? DateBirth { get; set; }
		public string? KTP { get; set; }

		public string? NoKK { get; set; }
		public string? Address { get; set; }
		public DateTime? EmployeeDate { get; set; }

      public DateTime? EndEmpDate { get; set; }

      public bool? IsActive { get; set; }
		public bool? IsStaff { get; set; }
		public string? BankName { get; set; }

      public string? AccountBank { get; set; }

      public string? NOBPJSTK { get; set; }

      public string? NOBPJSKS { get; set; }

      public string? NOBPJSPEN { get; set; }
		public bool MarriedStatus { get; set; }

      public string? EmployeeStatus { get; set; }
		public DateTime? StartActiveDate { get; set; }
		public DateTime? ContractStartDate { get; set; }
		public DateTime? ContractEndDate { get; set; }

		public string? MotherName { get; set; }

      public string? PhoneNumber { get; set; }
		public DateTime? CreatedAt { get; set; }
		public int? CreatedBy { get; set; }
		public DateTime? UpdatedAt { get; set; }
		public int? UpdatedBy { get; set; }
	}
}
