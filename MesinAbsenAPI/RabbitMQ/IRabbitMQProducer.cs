namespace MesinAbsenAPI.RabbitMQ {
   public interface IRabbitMQProducer {
      public void SendAbsenRealTimeMessage<T>(T message);

      public void SendRealtimeMessageToPayroll<T>(T message);

      public void SendLogMesinAbsenMessage<T>(T message);
   }
}
