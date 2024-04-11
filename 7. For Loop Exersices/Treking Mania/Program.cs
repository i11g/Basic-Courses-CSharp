using System;

namespace Treking_Mania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfGroups=int.Parse(Console.ReadLine());

            int numberOfPeople;
            int sumOfPeople = 0;
            int sump1=0;
            int sump2=0;
            int sump3=0;
            int sump4=0;
            int sump5=0;

            for (int i = 0; i < numberOfGroups; i++)
            {
                numberOfPeople = int.Parse(Console.ReadLine()); 

                if (numberOfPeople <=5)
                {
                    sump1 += numberOfPeople;
                }
                else if(numberOfPeople <=12)
                {
                    sump2 += numberOfPeople;
                }
                else if (numberOfPeople <= 25)
                {
                    sump3 += numberOfPeople;
                }
                else if (numberOfPeople <= 40)
                {
                    sump4 += numberOfPeople;
                }
                else if (numberOfPeople >=41)
                {
                    sump5 += numberOfPeople;
                }
                sumOfPeople=sump1 + sump2+sump3+sump4+sump5;
            }
            Console.WriteLine($"{(double)sump1/sumOfPeople*100:f2}%");
            Console.WriteLine($"{(double)sump2/sumOfPeople*100:f2}%");
            Console.WriteLine($"{(double)sump3/sumOfPeople*100:f2}%");
            Console.WriteLine($"{(double)sump4/sumOfPeople*100:f2}%");
            Console.WriteLine($"{(double)sump5/sumOfPeople*100:f2}%");
        }
    }
}
