using System;

namespace Open_the_secret_door
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int endOfHundreds = int.Parse(Console.ReadLine());
            int endOftens = int.Parse(Console.ReadLine());
            int endOfOnes = int.Parse(Console.ReadLine());

            for (int i = 2; i <= endOfHundreds; i += 2)
            {
                for (int j = 2; j <= endOftens; j++)
                {
                    bool isPrime = true;

                    for (int n = 2; n<=j/2; n++)
                    {
                        if (j % n == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                 if (isPrime)
                    {
                        for (int k = 2; k <= endOfOnes; k += 2)
                        {
                            Console.WriteLine($"{i}{j}{k}");
                        }
                    }
                }
            }
        }
    }
}

