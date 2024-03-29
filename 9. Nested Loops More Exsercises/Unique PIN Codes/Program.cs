using System;

namespace Unique_PIN_Codes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxFirstNumber = int.Parse(Console.ReadLine());
            int maxSecondNumber = int.Parse(Console.ReadLine());
            int maxThirdtNumber = int.Parse(Console.ReadLine());



            for (int i = 2; i <= maxFirstNumber; i += 2)
            {
                for (int j = 2; j <= maxSecondNumber; j++)
                {
                    bool isPrime = true;

                    for (int n = 2; n <= Math.Sqrt(j); n++)
                    {

                        if (j % n == 0)
                        {
                            isPrime = false;
                            break;
                        }

                    }
                    if (isPrime)
                    {

                        for (int k = 2; k <= maxThirdtNumber; k += 2)
                        {
                            Console.WriteLine($"{i}{j}{k}");
                        }
                    }
                }
            }
        }
    }
}
