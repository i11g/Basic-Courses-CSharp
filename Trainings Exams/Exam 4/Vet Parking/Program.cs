using System;

namespace Vet_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfDays = int.Parse(Console.ReadLine());
            int numberOfHours = int.Parse(Console.ReadLine());
            double totalPrice = 0;
            double totalTotal = 0;


            for (int i = 1; i <= numberOfDays; i++)
            {
                for (int j = 1; j <= numberOfHours; j++)
                {
                    if (i % 2 != 0)
                    {
                        if (j % 2 == 0)
                        {
                            totalPrice+= 1.25;
                        }
                        else if (j % 2 != 0)
                        {
                            totalPrice += 1;
                        }
                        
                    }
                    else if (i % 2 == 0)
                    {
                        if (j % 2 == 0)
                        {
                            totalPrice += 1;
                        }
                        else if (j % 2 != 0)
                        {
                            totalPrice += 2.50;
                        }
                        
                    }
                   
                }
                Console.WriteLine($"Day: {i} – {totalPrice:f2} leva");
                totalTotal += totalPrice;
                totalPrice=0;
            }
            Console.WriteLine($"Total: {totalTotal:f2} leva");
        }
    }
}