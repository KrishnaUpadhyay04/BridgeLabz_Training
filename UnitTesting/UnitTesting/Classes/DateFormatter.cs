using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace UnitTesting.Classes
{
    public class DateFormatter
    {
        public string FormatDate(string inputDate)
        {
            DateTime date = DateTime.ParseExact(
                inputDate,
                "yyyy-MM-dd",
                CultureInfo.InvariantCulture
            );

            return date.ToString("dd-MM-yyyy");
        }
    }
}
