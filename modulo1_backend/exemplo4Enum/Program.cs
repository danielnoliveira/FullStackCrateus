using System;

namespace exemplo4Enum
{
    public enum DaysOfWeek {
        Sunday = 0,
        Monday = 1,
        Tuesday = 2,
        Wednesday = 3,
        Thusday = 4,
        Friday = 5,
        Saturday = 6,
    }
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine((DaysOfWeek)2);
        }
    }
}
