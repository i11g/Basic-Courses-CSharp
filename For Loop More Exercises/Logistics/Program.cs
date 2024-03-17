using System;

namespace Logistics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbers=int.Parse(Console.ReadLine());
            double sumTons = 0;
            int tons1 = 0;
            int tons2 = 0;
            int tons3 = 0;
            int price1 = 0;
            int price2 = 0;
            int price3 = 0;
            double totalPrice = 0;
            double averagePrice = 0;

            for (int i = 0; i < numbers; i++)
            {
                int tons = int.Parse(Console.ReadLine());

                if (tons <= 3)
                {
                    tons1 += tons;
                    price1 += (tons * 200);
                }
                else if (tons >3 && tons <= 11)
                {
                    tons2 += tons;
                    price2+= tons * 175;
                }
                else if (tons > 12)
                {
                    tons3 += tons;
                    price3+= tons * 120;
                }
            }
                totalPrice = price1 + price2 + price3;
                sumTons=tons1 + tons2+ tons3;
                averagePrice = totalPrice / sumTons;
            
            double percentile1 = (tons1 / sumTons) * 100;
            double percentile2 = (tons2 / sumTons) * 100;
            double percentile3 =(tons3 / sumTons) * 100;


            Console.WriteLine($"{averagePrice:F2}");
            Console.WriteLine($"{percentile1:F2}%");
            Console.WriteLine($"{percentile2:F2}%");
            Console.WriteLine($"{percentile3:F2}%");
        }
    }
}
