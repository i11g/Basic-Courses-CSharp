using System;

namespace Average_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            double sum = 0;
            double number = 0;

            for (int i = 0; i <n ; i++)
            {
                number=int.Parse(Console.ReadLine());
                sum += number;
            }
            Console.WriteLine($"{sum/n:f2}");
        }
    }
}
