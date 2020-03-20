using System;
using System.Collections.Generic;
using System.Text;

namespace SI.Shared.Sif.Testclient.Common.Entities
{
    public static class DateTimeHelper
    {
        public static DateTime ConvertToSafeDate(DateTime currentDate)
        {
            int year = currentDate.Year;

            if (year < 1753)
            {
                year = 1753;
            }

            if (year > 9999)
            {
                year = 9999;
            }

            DateTime newDate = new DateTime(year, currentDate.Month, currentDate.Day);

            return newDate;
        }
    }
}
