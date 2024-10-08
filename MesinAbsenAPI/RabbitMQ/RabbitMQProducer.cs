using Newtonsoft.Json;
using RabbitMQ.Client;
using System.Text;

namespace MesinAbsenAPI.RabbitMQ {
   public class RabbitMQProducer : IRabbitMQProducer {

      public void SendAbsenRealTimeMessage<T>(T message) {
         var factory = new ConnectionFactory {
            HostName = "localhost:5672"
         };
         var connection = factory.CreateConnection();
         using var channel = connection.CreateModel();
         channel.QueueDeclare("absenRealTime", exclusive: false, durable: true, autoDelete: false);
         var json = JsonConvert.SerializeObject(message);
         var body = Encoding.UTF8.GetBytes(json);
         channel.BasicPublish(exchange: "", routingKey: "absenRealTime", body: body);
      }

      public void SendRealtimeMessageToPayroll<T>(T message) {
         var factory = new ConnectionFactory {
            HostName = "localhost:5672"
         };
         var connection = factory.CreateConnection();
         using var channel = connection.CreateModel();
         channel.QueueDeclare("absenRealTimeToPayroll", exclusive: false, durable: true, autoDelete: false);
         var json = JsonConvert.SerializeObject(message);
         var body = Encoding.UTF8.GetBytes(json);
         channel.BasicPublish(exchange: "", routingKey: "absenRealTimeToPayroll", body: body);
      }

      public void SendLogMesinAbsenMessage<T>(T message) {
			var factory = new ConnectionFactory {
				HostName = "localhost:5672"
			};
			var connection = factory.CreateConnection();
			using var channel = connection.CreateModel();
			channel.QueueDeclare("logMesinAbsen", exclusive: false, durable: true, autoDelete: false);
			var json = JsonConvert.SerializeObject(message);
			var body = Encoding.UTF8.GetBytes(json);
			channel.BasicPublish(exchange: "", routingKey: "logMesinAbsen", body: body);
		}


   }
}
