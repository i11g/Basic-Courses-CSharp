using System;

namespace Celsius_to_Farenhait
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double celsius=double.Parse(Console.ReadLine());
            double farebhait = (celsius * 9 / 5) + 32;
            Console.WriteLine($"{farebhait:F2}");
        }
    }
}
