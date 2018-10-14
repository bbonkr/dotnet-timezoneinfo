using System;
using System.Linq;

namespace Timezone.Sample
{

    public static class DateTimeOffsetExtensions
    {
        /// <summary>
        /// 지정된 시간대에 해당하는 시각을 계산합니다.
        /// </summary>
        /// <param name="dateTimeOffset"></param>
        /// <param name="timeZoneId">시간대 식별자</param>
        /// <returns></returns>
        public static DateTimeOffset ToLocalDateTime(this DateTimeOffset dateTimeOffset, string timeZoneId)
        {
            var timeZoneInfo = TimeZoneInfo.GetSystemTimeZones()
                .Where(t => t.Id.Equals(timeZoneId, StringComparison.OrdinalIgnoreCase))
                .FirstOrDefault();

            var localTime = TimeZoneInfo.ConvertTime(dateTimeOffset, timeZoneInfo);

            return localTime;
        }
    }
}