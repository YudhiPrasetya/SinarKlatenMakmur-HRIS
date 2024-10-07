using Newtonsoft.Json;
using StackExchange.Redis;

namespace ExceptionAPI.Services {
   public class CacheService : ICacheService {
      private IDatabase _db;
      public CacheService() {
         ConfigureRedis();
      }
      private void ConfigureRedis() {
         _db = ConnectionHelper.Connection.GetDatabase();
      }
      public T GetData<T>(string key) {
         //throw new NotImplementedException()
         var value = _db.StringGet(key);
         if(!string.IsNullOrEmpty(value)) {
            return JsonConvert.DeserializeObject<T>(value);
         }
         return default;
      }

      public object RemoveData(string key) {
         //throw new NotImplementedException();
         bool _isKeyExist = _db.KeyExists(key);
         if(_isKeyExist) {
            return _db.KeyDelete(key);
         }
         return false;
      }

      public bool SetData<T>(string key, T value, DateTimeOffset expirationTime) {
         //throw new NotImplementedException();
         TimeSpan expiryTime = expirationTime.DateTime.Subtract(DateTime.Now);
         var isSet = _db.StringSet(key, JsonConvert.SerializeObject(value), expiryTime);
         return isSet;
      }
   }
}
