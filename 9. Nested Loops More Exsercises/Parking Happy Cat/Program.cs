using System;

namespace Parking_Happy_Cat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfDays=int.Parse(Console.ReadLine());
            int numberOfHours=int.Parse(Console.ReadLine());
            double totaltax = 0;

            for (int i =1; i <=numberOfDays; i++)
            {
                double tax = 0;
                for (int j = 1; j <=numberOfHours; j++)
                {
                    
                    if (i%2==0&&j%2!=0)
                    {
                        tax+= 2.50;
                    }
                    else if (i%2!=0&&j%2==0)
                    {
                        tax += 1.25;
                    }
                    else
                    {
                        tax += 1.00;
                    }

                }
                Console.WriteLine($"Day: {i} – {tax:f2} leva");
                totaltax += tax;
            }
            Console.WriteLine($"Total: {totaltax} leva");


        }
    }
}
