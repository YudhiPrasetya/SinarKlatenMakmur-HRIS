using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKM.Shared.Helpers {
	public static class DtRange {
		public static IEnumerable<DateTime> EachDay(DateTime start, DateTime end) {
			for(var date = start.Date; date.Date <= end.Date; date = date.AddDays(1)) {
				yield return date;
			}
		}
	}
}
