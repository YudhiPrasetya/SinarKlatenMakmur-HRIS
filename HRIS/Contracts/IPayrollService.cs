using SKM.Shared.Dtos;

namespace HRIS.Contracts {
   public interface IPayrollService {
      Task<PayrollDTO>? AddPayroll(PayrollDTO payrollDTO);
      Task<bool> PostPayrollRange(List<PayrollDTO> payrollDTOs);
   }
}
