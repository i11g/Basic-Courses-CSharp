using System;

namespace Series_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string serialName=Console.ReadLine();
            int numberOfSeasons=int.Parse(Console.ReadLine());
            int numberOfEpizods=int.Parse(Console.ReadLine());
            double epizodTime=double.Parse(Console.ReadLine());

            epizodTime=epizodTime+epizodTime*0.20;
            int specialEpizods = numberOfSeasons * 10;
            double totalTime = numberOfSeasons * numberOfEpizods * epizodTime + specialEpizods;
            Console.WriteLine($"Total time needed to watch the {serialName} series is {Math.Round(totalTime)} minutes.");
        }
    }
}
