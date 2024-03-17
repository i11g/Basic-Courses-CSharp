using System;

namespace Truck_Driver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double kilometers = double.Parse(Console.ReadLine());
            double salary = 0;

            if (kilometers <= 5000)
            {
                if (season == "Spring" || season == "Autumn")
                {
                    salary = kilometers * 0.75*4;
                }
                else if (season == "Summer")
                {
                    salary = kilometers * 0.90*4;
                }
                else { salary = kilometers * 1.05 * 4; }
            }
            else if (kilometers <= 10000)
            {
                if (season == "Spring" || season == "Autumn")
                {
                    salary = kilometers * 0.95 * 4;
                }
                else if (season == "Summer")
                {
                    salary = kilometers * 1.10 * 4;
                }
                else { salary = kilometers * 1.25 * 4; }

            }
            else
            {
                salary = kilometers * 1.45 * 4;
            }


            Console.WriteLine($"{salary*0.9:f2}");
                }
    }
}
