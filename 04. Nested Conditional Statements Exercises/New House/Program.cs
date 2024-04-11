using System;

namespace New_House
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flowers=Console.ReadLine();
            double numberFlowers=int.Parse(Console.ReadLine());
            double bidget=double.Parse(Console.ReadLine());
            double totalBudget = 0;

            if (flowers== "Roses")
            {
                totalBudget = numberFlowers * 5.00;
                if (numberFlowers > 80)
                {
                    totalBudget = totalBudget - totalBudget * 0.1;
                }
            }
            else if (flowers == "Dahlias")
            {
                totalBudget = numberFlowers * 3.80;
                if (numberFlowers > 90)
                {
                    totalBudget = totalBudget - totalBudget * 0.15;
                }
            }
            else if (flowers == "Tulips")
            {
                totalBudget = numberFlowers * 2.80;
                if (numberFlowers > 80)
                {
                    totalBudget = totalBudget - totalBudget * 0.15;
                }
            }
            else if (flowers == "Narcissus")
            {
                totalBudget = numberFlowers * 3.00;
                if (numberFlowers < 120)
                {
                    totalBudget = totalBudget + totalBudget * 0.15;
                }
            }
            else if (flowers == "Gladiolus")
            {
                totalBudget = numberFlowers * 2.50;
                if (numberFlowers < 80)
                {
                    totalBudget = totalBudget + totalBudget * 0.20;
                }
            }
            if (totalBudget < bidget)
            {

                Console.WriteLine($"Hey, you have a great garden with {numberFlowers} {flowers} and {bidget-totalBudget:f2} leva left.");
            } 
            else
            {
                Console.WriteLine($"Not enough money, you need {totalBudget-bidget:f2} leva more.");
            }
        }
    }
}

