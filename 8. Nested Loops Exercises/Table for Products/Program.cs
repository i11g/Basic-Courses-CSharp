using System;

namespace Table_for_Products
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int multiOne = 1; multiOne <=10; multiOne++)
            {
                for (int multiTwo =1; multiTwo <= 10; multiTwo ++)
                {
                    Console.WriteLine($"{multiOne}*{multiTwo}={multiOne*multiTwo}");
                }
            }
        }
    }
}
