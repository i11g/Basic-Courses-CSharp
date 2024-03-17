using System;

namespace Number_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfDancers=int.Parse(Console.ReadLine());
            double numberOfPoints=double.Parse(Console.ReadLine());
            string season=Console.ReadLine();
            string place=Console.ReadLine();

            double sumEarned = 0;

            if(place== "Bulgaria")
            {
                sumEarned=numberOfDancers*numberOfPoints;
                if(season== "summer")
                {
                    sumEarned -= sumEarned * 0.05;
                }
                else
                {
                    sumEarned -= sumEarned * 0.08;
                }
            }
            else if (place== "Abroad")
            {
                sumEarned = numberOfDancers * numberOfPoints;
                sumEarned += sumEarned * 0.50;
                if(season=="summer")
                {
                    sumEarned -= sumEarned * 0.10;
                }
                else
                {
                    sumEarned -= sumEarned * 0.15;
                }
            }
            double sumcharity = sumEarned * 0.75;
            double sumLeft = sumEarned - sumcharity;
            Console.WriteLine($"Charity - {sumcharity:f2}");
            Console.WriteLine($"Money per dancer - {sumLeft/numberOfDancers:f2}");

        }
    }
}
