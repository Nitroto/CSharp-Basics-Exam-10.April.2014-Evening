using System;

namespace Volleyball
{
    class Volleyball
    {
        static void Main()
        {
            string year = Console.ReadLine();
            short p = short.Parse(Console.ReadLine());
            byte h = byte.Parse(Console.ReadLine());
            double normalWeekend = ((48 - h) * 0.75);
            double holidays = (p * 2 / 3.0);
            double leapYear = 1.15;
            double totalForYear = normalWeekend + holidays + h;
            if (year == "leap")
            {
                totalForYear = leapYear * totalForYear;
            }
            else
            {
            }
            Console.WriteLine((int)totalForYear);
        }
    }
}