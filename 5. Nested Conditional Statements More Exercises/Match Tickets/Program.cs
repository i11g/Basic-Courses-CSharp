using System;

namespace Match_Tickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int numberOfPeople = int.Parse(Console.ReadLine());
            double totalBudget = 0;

            if (category == "VIP")
            {

                if (numberOfPeople <= 4)
                {
                    totalBudget = budget * 0.75+numberOfPeople*499.99;
                }
                else if (numberOfPeople <= 9)
                {
                    totalBudget = budget * 0.60+ numberOfPeople * 499.99;
                }
                else if (numberOfPeople <= 24)
                {
                    totalBudget = budget * 0.50+ numberOfPeople * 499.99;
                }
                else if (numberOfPeople <= 49)
                {
                    totalBudget = budget * 0.40+ numberOfPeople * 499.99;
                }
                else
                {
                    totalBudget = budget * 0.25+ numberOfPeople * 499.99;
                }
            }
            if (category=="Normal")
            {

                if (numberOfPeople <= 4)
                {
                    totalBudget = budget * 0.75 + numberOfPeople * 249.99;
                }
                else if (numberOfPeople <= 9)
                {
                    totalBudget = budget * 0.60 + numberOfPeople * 249.99;
                }
                else if (numberOfPeople <= 24)
                {
                    totalBudget = budget * 0.50 + numberOfPeople * 249.99;
                }
                else if (numberOfPeople <= 49)
                {
                    totalBudget = budget * 0.40 + numberOfPeople * 249.99;
                }
                else
                {
                    totalBudget = budget * 0.25 + numberOfPeople * 249.99;
                }
            }
            
            if (budget>totalBudget)
            {
                Console.WriteLine($"Yes! You have {budget - totalBudget:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(budget - totalBudget):f2} leva.");
            }

        }
    }
}
