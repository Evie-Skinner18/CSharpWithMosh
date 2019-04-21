using System;
namespace ValidTime
{
    public static class DateExtensions
    {
        public static bool IsValidTime(this DateTime dateTime)
        {
            return dateTime > DateTime.Parse("00:00") && dateTime < DateTime.Parse("23:59");
        }

    }
}
