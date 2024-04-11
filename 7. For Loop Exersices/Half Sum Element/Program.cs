using System;

namespace Half_Sum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number=int.Parse(Console.ReadLine());
            int sum = 0;
            int maxNumber = int.MinValue;

            for (int i = 0; i < number; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                sum+= currentNumber;
                if (currentNumber>maxNumber)
                {
                    maxNumber = currentNumber;
                }

            }
            sum -= maxNumber;
            if(sum==maxNumber)
            {
                Console.WriteLine($"Yes");
                Console.WriteLine($"Sum = {sum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(sum-maxNumber)}");
            }
        }
    }
}
