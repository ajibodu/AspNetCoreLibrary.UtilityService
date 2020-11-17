using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace UtilityService.Implementation
{
    public static class DateTimeUtil
    {
        public static string con(this DateTime date)
        {
            string[] dateFormats = { "dd/MM/yyyy", "yyyy-MM-dd", "ddMMyyyy" };
            DateTime.ParseExact()
            var newDate = DateTime.ParseExact(date, dateFormats, CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal | DateTimeStyles.AdjustToUniversal);
            string parsedDate = newDate.ToString("yyyy-MM-dd");
            return parsedDate;
        }
    }
}
