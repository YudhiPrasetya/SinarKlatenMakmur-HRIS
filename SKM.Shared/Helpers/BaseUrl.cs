using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKM.Shared.Helpers {
   public static class BaseUrl {
      public const string LocalBaseUrl = "https://localhost:7023";
      public const string ServerBaseUrl  = "http://192.168.90.10:9023";
   }

   public static class BaseHub {
      public const string LocalHubUrl = "https://localhost:7218";
      //public const string ServerHubUrl = "http://192.168.90.10:9023";
      //public const string ServerHubUrl = "http://192.168.90.10:9084";
      public const string ServerHubUrl = "http://192.168.2.121:9084";
   }

   public static class KeyString {
      public const string Key = "YudhiFitriAzlanEmbuh1234567890!@#$%^&*()_+=";
   }
}
