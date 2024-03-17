using System;

namespace Numbers_to_1000_ending_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int number = 7; number <= 997; number++)
            {
                if (number%10==7)
                {
                    Console.WriteLine(number);
                }
            }             
        }
    }
}
