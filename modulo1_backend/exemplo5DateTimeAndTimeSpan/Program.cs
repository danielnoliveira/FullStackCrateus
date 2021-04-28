using System;

namespace exemplo5DateTimeAndTimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            var date = new DateTime(2021,4,28);
            var now = DateTime.Now;
            var today = DateTime.Today;

            Console.WriteLine(now);
            Console.WriteLine(today);

            var yesterday = now.AddDays(-1);
            var tomorrow = now.AddDays(1);
            Console.WriteLine(yesterday);
            Console.WriteLine(tomorrow);

            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToString("yyyy-MM-dd"));


        }
    }
}
