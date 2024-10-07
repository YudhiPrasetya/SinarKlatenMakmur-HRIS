using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

var factory = new ConnectionFactory
{
	HostName = "localhost",
};

var connection = factory.CreateConnection();
var channel = connection.CreateModel();

channel.QueueDeclare("department", exclusive: false);

var consumer = new EventingBasicConsumer(channel);
consumer.Received += (model, args) =>
{
	var body = args.Body.ToArray();
	var msg = Encoding.UTF8.GetString(body);
	Console.WriteLine(msg);
};
channel.BasicConsume(queue: "department", autoAck: true, consumer: consumer);

Console.ReadKey();
