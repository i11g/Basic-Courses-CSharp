using System;

namespace Back_to_the_Past
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money=double.Parse(Console.ReadLine());
            int year=int.Parse(Console.ReadLine());
            int count = 0;
            double money1 = 0;

            for (int i = 1800; i <= year; i++)
            {
                if (i % 2 == 0)
                {
                    money -= 12000;
                }
                else if (i % 2 !=0)
                {
                    money1 = (18 + count) * 50 + 12000;
                    money = money - money1;
                }
                count++;
            }
                if (money>=0)
                {
                    Console.WriteLine($"Yes! He will live a carefree life and will have {money:F2} dollars left.");
                }
                else
                {
                    money=Math.Abs(money);  
                    Console.WriteLine($"He will need {money:F2} dollars to survive.");
                }
            }
        }
    }

