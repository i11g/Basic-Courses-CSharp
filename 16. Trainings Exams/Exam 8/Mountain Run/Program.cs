using System;

namespace Mountain_Run
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double recordInSeconds=double.Parse(Console.ReadLine());
            double distanceInMeters=double.Parse(Console.ReadLine());
            double timeInSecendsForOneMeter=double.Parse(Console.ReadLine());

            double timeGeorgi=distanceInMeters*timeInSecendsForOneMeter+Math.Floor(distanceInMeters/50)*30;
            if(timeGeorgi<recordInSeconds)
            {
                Console.WriteLine($"Yes! The new record is {timeGeorgi:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No! He was {Math.Abs(recordInSeconds - timeGeorgi):f2} seconds slower.");
            }
        }
    }
}
