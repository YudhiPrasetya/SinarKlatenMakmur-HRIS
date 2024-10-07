namespace DepartmentAPI.RabbitMqProducer
{
	public interface IRabbitMqProducer
	{
		public void SendDepartmentMessage<T>(T message);
	}
}
