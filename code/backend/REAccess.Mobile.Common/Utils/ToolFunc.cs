#region Using
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
#endregion

namespace REAccess.Mobile.Common.Utils
{
    public static class ToolFunc
    {
        public static string DatetimeFormatter(DateTime? dateTime)
        {
            var datetimeStr = string.Empty;
            DateTimeFormatInfo dtFormat = new DateTimeFormatInfo();
            dtFormat.ShortDatePattern = "yyyy-MM-dd";
            datetimeStr = Convert.ToDateTime(dateTime, dtFormat).ToString("yyyy-MM-dd");

            return datetimeStr;
        }

    }
}
