using System;

namespace Sum_of_Prime_and_Non_Prime_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int number;

            int sumPrime = 0;
            int sumNonPrime = 0;

            while (input != "stop")
            {
                number = int.Parse(input);
                bool isPrime = true;
                if (number < 0)
                {
                    Console.WriteLine($"Number is negative.");
                    input = Console.ReadLine();
                    continue;
                }

                if (number == 0 || number == 1)
                {
                    sumPrime += number;
                }
                for (int del = 2; del < number; del++)
                {
                    if (number % del == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    sumPrime += number;
                }
                else
                {
                    sumNonPrime += number;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrime}");

        }
    }
}
