using KehadiranAPI.Abstracts;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace KehadiranAPI.RabbitMQ {
   public class MQConsumer: MqBase {
      readonly EventingBasicConsumer _consumer;
      public MQConsumer(ConnectionFactory factory): base(factory) {
         _consumer = new EventingBasicConsumer(Channel);
      }

      public void AddListener(string queueName, EventHandler<BasicDeliverEventArgs> handler) {
         _consumer.Received += handler;
         CreateQueueIfNotExiss(queueName);
         Channel.BasicConsume(queue: queueName, autoAck: true, consumer: _consumer, noLocal: false, exclusive: false, consumerTag: Guid.NewGuid().ToString(), arguments: new Dictionary<string, object>());
      }

      public void RemoveListener(EventHandler<BasicDeliverEventArgs> handler) {
         _consumer.Received -= handler;
      }
   }
}
