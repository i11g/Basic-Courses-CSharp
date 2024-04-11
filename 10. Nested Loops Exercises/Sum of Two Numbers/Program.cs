using System;

namespace Sum_of_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)


        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int combination = 0;
            int firstNumber = 0;
            int secondNumber = 0;
            bool isFound = false;

            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    combination++;
                    if (i + j == magicNumber)
                    {
                        isFound = true;
                        firstNumber = i;
                        secondNumber = j;
                        break;
                    }

                }
                if (isFound)
                {
                    break;
                }
            }
            if (isFound)
            {
                Console.WriteLine($"Combination N: {combination}  {firstNumber} + {secondNumber} = {magicNumber}");
            }
            else
            {
                Console.WriteLine($"{combination} - {magicNumber}");
            }
        }
    }
}
