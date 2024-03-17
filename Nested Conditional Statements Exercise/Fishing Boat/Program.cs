using System;

namespace Fishing_Boat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget=int.Parse(Console.ReadLine());
            string season=Console.ReadLine();
            int fishers=int.Parse(Console.ReadLine());
            double realBudget = 0;

            if (season=="Spring")
            {
                if (fishers<=6)
                {
                    realBudget = 3000-3000*0.1;
                }
                else if(fishers<=11)
                {
                    realBudget = 3000 - 3000 * 0.15;
                }
                else 
                {
                    realBudget = 3000 - 3000 * 0.25;
                }
            }
            else if (season == "Summer"||season=="Autumn")
            {
                if (fishers <= 6)
                {
                    realBudget = 4200 - 4200 * 0.1;
                }
                else if (fishers <= 11)
                {
                    realBudget = 4200 - 4200 * 0.15;
                }
                else 
                {
                    realBudget = 4200 - 4200 * 0.25;
                }
            }
            else if (season =="Winter")
            {
                if (fishers <= 6)
                {
                    realBudget = 2600 - 2600 * 0.1;
                }
                else if (fishers <= 11)
                {
                    realBudget = 2600 - 2600 * 0.15;
                }
                else 
                {
                    realBudget = 2600 - 2600 * 0.25;
                }
            }
            if(fishers %2==0&&season!= "Autumn")
            {
                
                {
                    realBudget -= realBudget * 0.05;
                }
            } 
            if (realBudget<budget)
            {
                Console.WriteLine($"Yes! You have {budget - realBudget:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {realBudget-budget:f2} leva.");
            }
        }
    }
}
