using System;

namespace Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double moneyForVacation=double.Parse(Console.ReadLine());
            double moneyExisting=double.Parse(Console.ReadLine());
            double money =0;
            int daysSpend = 0;
            int numberOfDays = 0;

            while (moneyExisting<moneyForVacation&&daysSpend<5) 
            {  
                string action=Console.ReadLine();
                money=double.Parse(Console.ReadLine());

                if(action=="spend")
                {
                    moneyExisting-=money;
                    numberOfDays++;
                    if(moneyExisting<0)
                    {
                        moneyExisting = 0;
                    }
                    daysSpend++;
                    if(daysSpend==5)
                    {
                        break;
                    }

                }
                if(action=="save")
                {
                    moneyExisting+=money;
                    numberOfDays++;
                    daysSpend = 0;
                }

            }

            if (daysSpend==5)
            {
                Console.WriteLine($"You can't save the money.");
                Console.WriteLine($"{daysSpend}");
            }
            if (moneyExisting >= moneyForVacation)
            {
                Console.WriteLine($"You saved the money for {numberOfDays} days.");
            }
        }
    }
}
