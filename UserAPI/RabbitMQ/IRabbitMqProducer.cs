namespace UserAPI.RabbitMQ
{
  public interface IRabbitMqProducer
  {
    public void SendUserMessage<T>(T message);
  }
}
