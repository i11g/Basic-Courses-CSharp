using System;

namespace Numbers2K_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number=int.Parse(Console.ReadLine());
            int currentNumber=1;

            while (number>=currentNumber)
            {
                Console.WriteLine(currentNumber);
                currentNumber=2*currentNumber+1;

            }
        }
    }
}
