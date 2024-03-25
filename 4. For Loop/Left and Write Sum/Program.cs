using System;

namespace Left_and_Write_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            int sum1 = 0;
            int sum2 = 0;

            for (int i = 0; i < n; i++)
            {
                int currentNumber1 = int.Parse(Console.ReadLine());
                sum1 += currentNumber1;
             }
            for (int i = 0; i < n; i++)
            {
                int currentNumber2 = int.Parse(Console.ReadLine());
                sum2 += currentNumber2;
            }
            if (sum1 == sum2)
            {
                Console.WriteLine($"Yes, sum = {sum1}");
            }
            else 
            {
                Console.WriteLine($"No, diff = {Math.Abs(sum1-sum2)}");
            }
        }
    }
}
