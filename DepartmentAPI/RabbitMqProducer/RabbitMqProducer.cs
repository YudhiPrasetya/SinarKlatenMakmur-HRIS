using Newtonsoft.Json;
using RabbitMQ.Client;
using System.Text;

namespace DepartmentAPI.RabbitMqProducer
{
	public class RabbitMqProducer : IRabbitMqProducer
	{
		public void SendDepartmentMessage<T>(T message)
		{
			//throw new NotImplementedException();
			var factory = new ConnectionFactory
			{
				HostName = "localhost",
			};

			var connection = factory.CreateConnection();
			using var channel = connection.CreateModel();
			channel.QueueDeclare("department", exclusive: false);
			var json = JsonConvert.SerializeObject(message);
			var body = Encoding.UTF8.GetBytes(json);
			channel.BasicPublish(exchange: "", routingKey: "department", body: body);
		}
	}
}
