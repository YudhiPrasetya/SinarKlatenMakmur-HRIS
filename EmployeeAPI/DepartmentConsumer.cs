using EmployeeAPI.Services;
using MassTransit;
using Microsoft.AspNetCore.Components;
using SKM.Shared.Models;

namespace EmployeeAPI {
   public class DepartmentConsumer : IConsumer<DepartmentCreated> {
      [Inject]IEmployeeService employeeService { get; set;}

      public async Task Consume(ConsumeContext<DepartmentCreated> context) {
         //throw new NotImplementedException();
         var dataFromDepartmentProducer = context.Message;
         Console.WriteLine(dataFromDepartmentProducer);
         //await employeeService.UpdateBulkEmployee_DepartmentName(dataFromDepartmentProducer);
      }


   }
}
