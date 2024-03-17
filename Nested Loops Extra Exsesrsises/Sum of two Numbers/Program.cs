using System;

namespace Sum_of_two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int srtart=int.Parse(Console.ReadLine());
            int end=int.Parse(Console.ReadLine());
            int magicNumber=int.Parse(Console.ReadLine());

            int combination = 0;
            bool ifFound = false; 

            for (int i =srtart; i <=end; i++)
            {
                for (int j = srtart; j <=end; j++)
                {   
                    combination++;
                    if(i+j==magicNumber)
                    {
                        Console.WriteLine($"Combination N:{combination} ({i} + {j} = {magicNumber})");
                        ifFound = true;
                        break;
                    }
                }
                if (ifFound)
                {
                    break;
                }

            }
            if (!ifFound) {
                Console.WriteLine($"{combination} combinations - neither equals {magicNumber}");
            }
        }
    }
}
