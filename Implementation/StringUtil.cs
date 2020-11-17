using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace UtilityService.Implementation
{
    public static class StringUtil
    {
        public static string FormatPhoneNumberTo234(this string phoneNumber)
        {
            if ((phoneNumber[0] + "") == "0")
            {
                phoneNumber = "234" + phoneNumber.Remove(0, 1);
            }
            phoneNumber = phoneNumber.Replace("+", "");
            return phoneNumber;
        }

        public static string FormatPhoneNumberToPlus234(this string phoneNumber)
        {
            if ((phoneNumber[0] + "") == "0")
            {
                phoneNumber = "+234" + phoneNumber.Remove(0, 1);
            }
            phoneNumber = phoneNumber.Replace("+", "");
            return phoneNumber;
        }

        /// <summary>
        /// convert the date string to desired format
        /// </summary>
        /// <param name="date"></param>
        /// <param name="format">required date output format "yyyyMMdd"</param>
        /// <returns></returns>
        public static string ConvertDateFormat(this string date, string format)
        {
            string[] dateFormats = { "dd/MM/yyyy", "yyyy-MM-dd", "ddMMyyyy" };
            var newDate = DateTime.ParseExact(date, dateFormats, CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal | DateTimeStyles.AdjustToUniversal);
            string parsedDate = newDate.ToString(format);
            return parsedDate;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="word"></param>
        /// <param name="allowedCharacter">special characters permited</param>
        /// <returns></returns>
        public static string RemoveSpecialCharacters(this string word, string[] allowedCharacter = null)
        {
            System.Text.StringBuilder sb = new StringBuilder();
            if(allowedCharacter == null) 
                allowedCharacter = new string[] { };

            foreach (char c in word)
            {
                if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || allowedCharacter.Contains(c.ToString()))
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }
    }
}
