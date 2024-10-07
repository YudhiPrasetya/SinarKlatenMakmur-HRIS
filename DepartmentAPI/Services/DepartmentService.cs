using DepartmentAPI.Conversions;
using DepartmentAPI.Data;
using DepartmentAPI.Models;
using DepartmentAPI.Utility;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using RabbitMQ.Client;
using SKM.Shared.Dtos;
using System.Text;
//using Newtonsoft.Json;
//using RabbitMQ.Client;
//using System.Text;
//using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace DepartmentAPI.Services {
   public class DepartmentService : IDepartmentService {
      private readonly DepartmentDbContextClass departmentDbContextClass;

      public DepartmentService(DepartmentDbContextClass departmentDbContextClass) {
         this.departmentDbContextClass = departmentDbContextClass;
      }
      public async Task<Department> AddDepartment(DepartmentDTO departmentDTO) {
         //throw new NotImplementedException();
         var rst = await departmentDbContextClass.Departments.AddAsync(departmentDTO.ConvertToModel());
         await departmentDbContextClass.SaveChangesAsync();

         return rst.Entity;
      }

      public async Task<Department> DeleteDepartmentAsync(int id) {
         //throw new NotImplementedException();
         var department = await departmentDbContextClass.Departments.FindAsync(id);
         if (department != null) {
            departmentDbContextClass.Departments.Remove(department);
            await departmentDbContextClass.SaveChangesAsync();
         }

         return department;
      }

      public async Task<Department> GetDepartmentByIdAsync(int id) {
         //throw new NotImplementedException();
         return await departmentDbContextClass.Departments.FindAsync(id);
      }

      public IEnumerable<Department> GetDepartmentListAsync() {
         //throw new NotImplementedException();
         //var departments = await _dbContext.Departments.ToListAsync();
         //return departments;
         return departmentDbContextClass.Departments.ToList();
      }

      public async Task<Department> UpdateDepartmentAsync(DepartmentDTO departmentDTO) {
         //throw new NotImplementedException();
         var rst = departmentDbContextClass.Departments.Update(departmentDTO.ConvertToModel());
         await departmentDbContextClass.SaveChangesAsync();

         return rst.Entity;
      }

      public bool SendDepartmentOffer(DepartmentOffer departmentOffer) {
         //throw new NotImplementedException();
         var RabbitMQServer = "";
         var RabbitMQUserName = "";
         var RabbitMQPassword = "";

         if (Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Production") {
            RabbitMQServer = Environment.GetEnvironmentVariable("RABBIT_MQ_SERVER");
            RabbitMQUserName = Environment.GetEnvironmentVariable("RABBIT_MQ_USERNAME");
            RabbitMQPassword = Environment.GetEnvironmentVariable("RABBIT_MQ_PASSWORD");
         }
         else {
            RabbitMQServer = StaticConfigurationManager.AppSetting["RabbitMQ:RabbitURL"];
            RabbitMQUserName = StaticConfigurationManager.AppSetting["RabbitMQ:Username"];
            RabbitMQPassword = StaticConfigurationManager.AppSetting["RabbitMQ:Password"];
         }

         try {
            var factory = new ConnectionFactory() {
               HostName = RabbitMQServer,
               UserName = RabbitMQUserName,
               Password = RabbitMQPassword
            };
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel()) {
               channel.ExchangeDeclare(StaticConfigurationManager.AppSetting["RabbitMqSettings:ExchangeName"], StaticConfigurationManager.AppSetting["RabbitMqSettings:ExchangeType"]);

               channel.QueueDeclare(queue: StaticConfigurationManager.AppSetting["RabbitMqSettings:QueueName"], durable: true, exclusive: false, autoDelete: false, arguments: null);

               channel.QueueBind(queue: StaticConfigurationManager.AppSetting["RabbitMqSettings:QueueName"], exchange: StaticConfigurationManager.AppSetting["RabbitMqSettings:ExchangeName"], routingKey: StaticConfigurationManager.AppSetting["RabbitMqSettings:RouteKey"]);

               string departmentDetail = JsonConvert.SerializeObject(departmentOffer);
               var body = Encoding.UTF8.GetBytes(departmentDetail);
               var properties = channel.CreateBasicProperties();
               properties.Persistent = true;

               // Publish message
               channel.BasicPublish(exchange: StaticConfigurationManager.AppSetting["RabbitMqSettings:ExchangeName"], routingKey: StaticConfigurationManager.AppSetting["RabbitMqSettings:RouteKey"], basicProperties: properties, body: body);

               return true;
            }


         }
         catch (Exception) {

            //throw;
         }
         return false;
      }
   }
}
