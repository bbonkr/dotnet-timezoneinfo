using System;
using System.Linq;

namespace Timezone.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // 현재시각
                var now = DateTimeOffset.UtcNow;

                Console.WriteLine($"[Now]");
                Console.WriteLine($"UTC: {now:yyyy-MM-dd HH:mm:ss}");
                Console.WriteLine($"KST: {now.ToLocalDateTime("Korea Standard Time"):yyyy-MM-dd HH:mm:ss}");
                Console.WriteLine($"PST: {now.ToLocalDateTime("Pacific Standard Time"):yyyy-MM-dd HH:mm:ss}");

                Console.WriteLine("".PadLeft(80, '='));

                Console.WriteLine($"{"Id",-32} | {"Standard name",-32} | Offset");
                Console.WriteLine("".PadLeft(80, '-'));

                foreach (var timezone in TimeZoneInfo.GetSystemTimeZones().OrderBy(z => z.BaseUtcOffset))
                {
                    Console.WriteLine($"{timezone.Id,-32} | {timezone.StandardName,-32} | {timezone.BaseUtcOffset}");
                }

                Console.WriteLine("".PadLeft(80, '-'));
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
