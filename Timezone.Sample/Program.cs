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
                Console.WriteLine($"{"Id", -32} | {"Standard name",-32} | Offset");
                Console.WriteLine("".PadLeft(80, '-'));

                foreach (var timezone in TimeZoneInfo.GetSystemTimeZones().OrderBy(z=>z.BaseUtcOffset))
                {
                    Console.WriteLine($"{timezone.Id, -32} | {timezone.StandardName, -32} | {timezone.BaseUtcOffset}");
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
