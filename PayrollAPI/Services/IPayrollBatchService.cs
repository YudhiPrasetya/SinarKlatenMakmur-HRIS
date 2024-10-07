using PayrollAPI.Model;

namespace PayrollAPI.Services {
   public interface IPayrollBatchService {
      Task<IEnumerable<Payroll>> GetPayrollBatchAsync();
   }
}
