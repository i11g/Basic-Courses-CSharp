using System;
using System.Threading.Channels;

namespace Numbers_in_range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number=int.Parse(Console.ReadLine());

            while (number<=0||number>100)
            {
                Console.WriteLine($"Invalid number!");
                number=int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"The number is: {number}");
        }
    }
}
