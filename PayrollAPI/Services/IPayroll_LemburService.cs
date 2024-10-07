using PayrollAPI.Model;

namespace PayrollAPI.Services {
   public interface IPayroll_LemburService {
      Task<IEnumerable<Payroll>> GetPayrolls_Lembur();
   }
}
