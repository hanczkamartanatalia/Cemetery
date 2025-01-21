using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidatorLib
{
    public static class DateValidator
    {
        public static bool IsDateTimeBefore(DateTime toCheck, DateTime? toDateTime = null)
        {
            DateTime referenceDate = toDateTime ?? DateTime.Now;
            return toCheck < referenceDate;
        }

        public static bool IsDateTimeAfter(DateTime toCheck, DateTime? toDateTime = null)
        {
            DateTime referenceDate = toDateTime ?? DateTime.Now;
            return toCheck > referenceDate;
        }

        public static bool IsValidDateTime(string dateString)
        {
            return DateTime.TryParse(dateString, out _);
        }

        public static bool IsDateAfter(DateOnly dateToCheck, DateTime? dateTime = null)
        {
            DateOnly referenceDate = dateTime.HasValue
                ? DateOnly.FromDateTime(dateTime.Value)
                : DateOnly.FromDateTime(DateTime.Now);
            return dateToCheck > referenceDate;
        }

    }
}
