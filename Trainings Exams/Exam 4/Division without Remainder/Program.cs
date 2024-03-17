using System;
using System.Security.Cryptography;

namespace Division_without_Remainder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number=int.Parse(Console.ReadLine());
            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            int total = 0;

            for (int i = 0; i < number; i++)
            {
                int currentNumber=int.Parse(Console.ReadLine());
                if(currentNumber%2==0)
                {
                    p1++;
                }
                if(currentNumber%3==0)
                {
                    p2++;
                }
                if(currentNumber %4==0) 
                {
                    p3++;
                }
                total++;
            }
            Console.WriteLine($"{(double)p1/total*100:f2}%");
            Console.WriteLine($"{(double)p2/total*100:f2}%");
            Console.WriteLine($"{(double)p3/total*100:f2}%");
        }
    }
}
