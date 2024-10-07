using PayrollAPI.Model;
using SKM.Shared.Dtos;

namespace PayrollAPI.Services {
   public interface IPayrollService {
      Task<IEnumerable<Payroll>> GetPayrollsAsync();
      Task<Payroll> AddPayroll(Payroll newPayroll);
      Task<bool> PostPayrollRange(List<PayrollDTO> listPayrolls);
   }
}
