using System;

namespace Rental_Car
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget=double.Parse(Console.ReadLine());
            string season=Console.ReadLine();
            string type=string.Empty;
            string car=string.Empty;

            if (budget<=100)
            {
                type = "Economy class";
                if (season=="Summer")
                {
                    car = "Cabrio";
                    budget = budget*0.35;
                }
                else
                {
                    car = "Jeep";
                    budget = budget * 0.65;
                }
            }
            else if (budget<=500)
            {
                type = "Compact class";
                if (season == "Summer")
                {
                    car = "Cabrio";
                    budget = budget * 0.45;
                }
                else
                {
                    car = "Jeep";
                    budget = budget * 0.80;
                }
            }
            else
            {
                type = "Luxury class";
                car = "Jeep";
                budget = budget * 0.90;
                
            }
            Console.WriteLine(type);
            Console.WriteLine($"{car} - {budget:f2}");
        }
    }
}
