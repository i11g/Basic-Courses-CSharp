using System;

namespace Flowers1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hrizantemi=int.Parse(Console.ReadLine());
            int roses=int.Parse(Console.ReadLine());
            int tulips=int.Parse(Console.ReadLine());
            string seson=Console.ReadLine();
            char holiday=char.Parse(Console.ReadLine());
            int numberOfFlowers = hrizantemi + roses + tulips;
            double price = 0;

            if (seson == "Spring")
            {
                if (holiday == 'Y')
                {
                    price = (hrizantemi * 2.00 + roses * 4.10 + tulips * 2.50) * 1.15;
                    if (tulips > 7)
                    {
                        price -= price * 0.05;
                    }
                    else if (numberOfFlowers > 20)
                    {
                        price -= price * 0.20;
                    }
                }
                else
                {
                    price = (hrizantemi * 2.00 + roses * 4.10 + tulips * 2.50);
                    if (tulips > 7)
                    {
                        price -= price * 0.05;
                    }
                    else if (numberOfFlowers > 20)
                    {
                        price -= price * 0.20;
                    }
                }
            }
           else if (seson == "Summer")
                {
                    if (holiday == 'Y')
                    {
                        price = (hrizantemi * 2.00 + roses * 4.10 + tulips * 2.50) * 1.15;
                        if (numberOfFlowers > 20)
                        {
                            price -= price * 0.20;
                        }
                    }
                    else
                    {
                        price = (hrizantemi * 2.00 + roses * 4.10 + tulips * 2.50);
                        if (numberOfFlowers > 20)
                        {
                            price -= price * 0.20;
                        }
                    }

                }
            else if (seson == "Autumn")
            {
                if (holiday == 'Y')
                {
                    price = (hrizantemi * 3.75 + roses * 4.50 + tulips * 4.15) * 1.15;
                    if (numberOfFlowers > 20)
                    {
                        price -= price * 0.20;
                    }
                }
                else
                {
                    price = (hrizantemi * 3.75 + roses * 4.50 + tulips * 4.15);
                    if (numberOfFlowers > 20)
                    {
                        price -= price * 0.20;
                    }
                }

            }
            else if (seson == "Winter")
            {
                if (holiday == 'Y')
                {
                    price = (hrizantemi * 3.75 + roses * 4.50 + tulips * 4.15) * 1.15;
                    if (roses > 10)
                    {
                        price -= price * 0.10;
                    }

                    if (numberOfFlowers > 20)
                    {
                        price -= price * 0.20;
                    }
                }
                else
                {
                    price = (hrizantemi * 3.75 + roses * 4.50 + tulips * 4.15);
                    if (roses >= 10)
                    {
                        price -= price * 0.10;
                    }
                    if (numberOfFlowers > 20)
                    {
                        price -= price * 0.20;
                    }
                }

            }
            Console.WriteLine($"{price+2:f2}");
        }
    }
}
