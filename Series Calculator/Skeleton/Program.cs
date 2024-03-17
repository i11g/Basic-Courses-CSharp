using System;

namespace Skeleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minutesControl=int.Parse(Console.ReadLine());
            int secondsControl=int.Parse(Console.ReadLine());
            double length=double.Parse(Console.ReadLine());
            int secondsForOnehundredMeters=int.Parse(Console.ReadLine());

            secondsControl = minutesControl * 60 + secondsControl;
            double timeGain = (length / 120) * 2.5;
            double timeMartin = (length / 100) * secondsForOnehundredMeters - timeGain;
            if(timeMartin <=secondsControl)
            {
                Console.WriteLine($"Marin Bangiev won an Olympic quota!");
                Console.WriteLine($"His time is {timeMartin:f3}.");
            }
            else
            {
                Console.WriteLine($"No, Marin failed! He was {timeMartin - secondsControl:f3} second slower.");
            }
        }
    }
}
