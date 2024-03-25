using System;

namespace Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget=double.Parse(Console.ReadLine());
            string season=Console.ReadLine();
            double spendBudget = 0;
            string type = "";
            string destination = "";

            if (budget<=100)
            {
                if (season=="summer")
                {
                    spendBudget=budget*0.3;
                    type = "Camp";
                    destination = "Bulgaria";
                }
                else if (season=="winter")
                {
                    spendBudget = budget * 0.7;
                    type = "Hotel";
                    destination = "Bulgaria";
                }
            }
           else if (budget <= 1000)
            {
                if (season == "summer")
                {
                    spendBudget = budget * 0.4;
                    type = "Camp";
                    destination = "Balkans";
                }
                else if (season == "winter")
                {
                    spendBudget = budget * 0.8;
                    type = "Hotel";
                    destination = "Balkans";
                }
            }
            if (budget > 1000)
            {
                if (season == "summer"||season=="winter")
                {
                    spendBudget = budget * 0.9;
                    type = "Hotel";
                    destination = "Europe";
                }
            }
            Console.WriteLine("Somewhere in"+" "+ (destination));
            Console.WriteLine($"{type} - {spendBudget:f2}");

        }
    }
}
