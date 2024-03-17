using System;

namespace Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget=double.Parse(Console.ReadLine());
            string season=Console.ReadLine();
            string accomodation = string.Empty;
            string country=string.Empty;

            if (budget<=1000 )
            {
                accomodation="Camp";
                if (season=="Summer")
                {
                    country = "Alaska";
                    budget = budget * 0.65;
                }
                else 
                {
                    country = "Morocco";
                    budget = budget * 0.45;

                }
            }
            else if (budget<=3000 ) 
            {
                accomodation = "Hut";
                if (season == "Summer")
                {
                    country = "Alaska";
                    budget = budget * 0.80;
                }
                else
                {
                    country = "Morocco";
                    budget = budget * 0.60;

                }
            }
            else 
            {
                accomodation = "Hotel";
                if (season == "Summer")
                {
                    country = "Alaska";
                    budget = budget * 0.90;
                }
                else
                {
                    country = "Morocco";
                    budget = budget * 0.90;

                }
            }
            Console.WriteLine($"{country} - {accomodation} - {budget:f2}");
        }
    }
}
