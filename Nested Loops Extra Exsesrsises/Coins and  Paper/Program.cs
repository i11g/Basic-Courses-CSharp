using System;
using System.Diagnostics.CodeAnalysis;

namespace Coins_and__Paper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbersOneLev=int.Parse(Console.ReadLine());
            int numbersTwoLevs=int.Parse(Console.ReadLine());
            int numbersFiveLevs=int.Parse(Console.ReadLine());
            int sum = int.Parse(Console.ReadLine()); 

            for (int i = 0; i <=numbersFiveLevs ; i++)
            {
                for (int j = 0; j <=numbersTwoLevs; j++)
                {
                    for (int k = 0; k <=numbersOneLev; k++)
                    {
                        if(i*5+j*2+k*1 == sum)
                        {
                            Console.WriteLine($"{k} * 1 lv. + {j} * 2 lv. + {i} * 5 lv. = {sum} lv.");
                        }
            
                    }
                }
            }
        }
    }
}
