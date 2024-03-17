using System;

namespace Holiday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double moneyNeeded=double.Parse(Console.ReadLine());
            double existingMoney=double.Parse(Console.ReadLine());
            int daysSpend = 0;
            int days = 0;
            bool moneySaved = false;


            while (existingMoney < moneyNeeded)
            {
                string action = Console.ReadLine();
                double sum = double.Parse(Console.ReadLine());

                if (action == "save")
                {
                    existingMoney += sum;
                    days++;
                }
                else if (action == "spend")
                {
                    existingMoney -= sum;
                    daysSpend++;

                    if (existingMoney < 0)
                    {
                        existingMoney = 0;
                    }
                    if (daysSpend == 5)
                    {
                        break;
                    }                   
                }
                
            }

            if (daysSpend == 5)
            {
                Console.WriteLine($"You can't save the money.");
                Console.WriteLine(daysSpend);
            }

            if (existingMoney>= moneyNeeded)
                {
                    Console.WriteLine($"You saved the money for {days + daysSpend} days.");
                }
                
}        }
    }

