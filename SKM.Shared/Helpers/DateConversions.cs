using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKM.Shared.Helpers {
   public static class DateConversions {
      public static int DateTimeToInt(DateTime? date) {
         //return (int)(date.Date - new DateTime(1900, 1, 1)).TotalDays + 2;
         return (int)(date.Value - new DateTime(1900, 1, 1)).TotalDays + 2;
      }

      public static DateTime IntToDateTime(int intDate) {
         return new DateTime(1900, 1, 1).AddDays(intDate - 2);
      }

      public static string DateToString(DateTime? date) {
         string strYear = date.Value.Year.ToString();
         string strMonth = (date.Value.Month < 10 ? "0" + date.Value.Month.ToString() : date.Value.Month.ToString());
         string strDay = (date.Value.Day < 10 ? "0" + date.Value.Day.ToString() : date.Value.Day.ToString());

         return $"{strYear}-{strMonth}-{strDay}";
      }

      public static DateTime StringToDate(string strDate) {
         var arrStrDate = strDate.Split("-");
         DateTime dt = new DateTime(int.Parse(arrStrDate[0]), int.Parse(arrStrDate[1]), int.Parse(arrStrDate[2]));

         return dt;
      }
   }
}
