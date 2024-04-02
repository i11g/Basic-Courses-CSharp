using System;

namespace Fish_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length=int.Parse(Console.ReadLine());
            int widgth=int.Parse(Console.ReadLine());
            int heigth=int.Parse(Console.ReadLine());
            double percentile=double.Parse(Console.ReadLine());

            double volume = length * widgth * heigth;
            double litters = volume / 1000;
            double percentile1 = percentile / 100;
            double totalVolume1 = (1.00 - percentile1);
            double totalvolume=litters*totalVolume1;
            Console.WriteLine(totalvolume);
        }
    }
}
