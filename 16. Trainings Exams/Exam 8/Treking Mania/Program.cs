using System;

namespace Treking_Mania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfGroups=int.Parse(Console.ReadLine());
            int numberOfPeople;
            int claimMussala = 0;
            int claimMonblan = 0;
            int claimKalimandzaro = 0;
            int claimK2 = 0;
            int claimEverest = 0;
            int total = 0;
            
            for (int i = 1; i <=numberOfGroups; i++)
            {
                numberOfPeople=int.Parse(Console.ReadLine());

                if(numberOfPeople<=5)
                {
                    claimMussala += numberOfPeople;
                }
                else if(numberOfPeople<=12)
                {
                    claimMonblan+= numberOfPeople;
                }
                else if (numberOfPeople <= 25)
                {
                    claimKalimandzaro += numberOfPeople;
                }
                else if (numberOfPeople <= 40)
                {
                    claimK2 += numberOfPeople;
                }
                else if (numberOfPeople >40)
                {
                    claimEverest += numberOfPeople;
                }
                total += numberOfPeople;
            }
            Console.WriteLine($"{(double) claimMussala / total * 100:f2}%");
            Console.WriteLine($"{(double) claimMonblan / total * 100:f2}%");
            Console.WriteLine($"{(double) claimKalimandzaro / total * 100:f2}%");
            Console.WriteLine($"{(double) claimK2 / total * 100:f2}%");
            Console.WriteLine($"{(double) claimEverest / total * 100:f2}%");


        }
    }
}
