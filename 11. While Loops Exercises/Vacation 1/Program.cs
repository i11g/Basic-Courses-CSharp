using System;

namespace Vacation_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double moneyNeeded = double.Parse(Console.ReadLine());
            double existingMoney = double.Parse(Console.ReadLine());
            string action;
            double sumAction;
            int spend = 0;
            int daysCount = 0;

            while (moneyNeeded > existingMoney)
            {
                action = Console.ReadLine();
                sumAction = double.Parse(Console.ReadLine());
                daysCount++;
                if (action == "spend")
                {
                    spend++;
                    if (spend == 5)
                    {
                        Console.WriteLine($"You can't save the money.");
                        Console.WriteLine($"{spend}");
                        break;
                    }
                    existingMoney -= sumAction;
                    if (existingMoney < 0)
                    {
                        existingMoney = 0;
                    }
                }
                else 
                {
                    existingMoney += sumAction;
                    spend = 0;
                }

            }
            if (existingMoney >= moneyNeeded)
            {
                Console.WriteLine($"You saved the money for {daysCount} days.");
            }
            
        }
    }
}
