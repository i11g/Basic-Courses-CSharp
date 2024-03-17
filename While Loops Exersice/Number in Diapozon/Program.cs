using System;

namespace Number_in_Diapozon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            while (true)
            {
                if (n >= 1 && n <= 100)
                {
                    Console.WriteLine($"The number is: {n}");
                }

                else if (n < 1 || n > 100)
                {
                    Console.WriteLine($"Invalid Number!");
                }
                n = int.Parse(Console.ReadLine());
            }
        }
    }
}