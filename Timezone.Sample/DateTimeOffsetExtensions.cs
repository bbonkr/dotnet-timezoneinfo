using System;
using System.Linq;

namespace Timezone.Sample
{

    public static class DateTimeOffsetExtensions
    {
        public static DateTimeOffset ToLocalDateTime(this DateTimeOffset dateTimeOffset, string timezone)
        {
            var timeZoneInfo = TimeZoneInfo.GetSystemTimeZones()
                .Where(t => t.Id.Equals(timezone, StringComparison.OrdinalIgnoreCase))
                .FirstOrDefault();

            var localTime = TimeZoneInfo.ConvertTime(dateTimeOffset, timeZoneInfo);

            return localTime;
        }
    }
}