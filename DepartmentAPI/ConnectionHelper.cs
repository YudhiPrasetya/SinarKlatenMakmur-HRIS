using StackExchange.Redis;

namespace Microservices.DepartmentAPI{
   public class ConnectionHelper {
      private static Lazy<ConnectionMultiplexer> lazyConnection;
      public static ConnectionMultiplexer Connection {
         get {
            return lazyConnection.Value;
         }
      }
      static ConnectionHelper() {
         ConnectionHelper.lazyConnection = new Lazy<ConnectionMultiplexer>(() => {
            return ConnectionMultiplexer.Connect(ConfigurationManager.AppSetting["RedisCacheUrl"]);
         });
      }
   }
}
