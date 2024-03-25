using System;

namespace Series_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string serialName=Console.ReadLine();
            int numberOfSeason=int.Parse(Console.ReadLine());
            int numberOfEpisods=int.Parse(Console.ReadLine());
            double timeFrame=double.Parse(Console.ReadLine());

            timeFrame += timeFrame * 0.2;
            double extraTimeSpecialEpizods = numberOfSeason * 10;
            double totalTime = numberOfSeason * numberOfEpisods * timeFrame + extraTimeSpecialEpizods;
            Console.WriteLine($"Total time needed to watch the {serialName} series is {totalTime} minutes.");
        }
    }
}
