using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidatorLib
{
    public static class DateValidator
    {
        public static bool DateTimeBefore(DateTime toCheck, DateTime? toDateTime = null)
        {
            DateTime referenceDate = toDateTime ?? DateTime.Now;
            return toCheck < referenceDate;
        }

        public static bool DateTimeAfter(DateTime toCheck, DateTime? toDateTime = null)
        {
            DateTime referenceDate = toDateTime ?? DateTime.Now;
            return toCheck > referenceDate;
        }

        public static bool IsValidDateTime(string dateString)
        {
            return DateTime.TryParse(dateString, out _);
        }
    }
}
