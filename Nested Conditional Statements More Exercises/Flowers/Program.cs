using System;
using System.ComponentModel.Design;
using System.Runtime.Intrinsics.X86;

namespace Flowers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chrysantemums = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int tulips = int.Parse(Console.ReadLine());
            string season = (Console.ReadLine());
            char holiday = char.Parse(Console.ReadLine());
            int numberOfFlowers = chrysantemums + roses + tulips;
            double price = 0;

            switch (season)
            {
                case "Spring":

                    if (holiday == 'Y')
                    {
                        if (numberOfFlowers > 20 && tulips <= 7)
                        {
                            price = (chrysantemums * 2 + roses * 4.1 + tulips * 2.50) * 1.15;
                            price -= price * 0.2;
                        }
                        else if (numberOfFlowers > 20 && tulips > 7)
                        {
                            double price1 = ((chrysantemums * 2 + roses * 4.1 + tulips * 2.50) * 1.15) * 0.05;
                            price = (chrysantemums * 2 + roses * 4.1 + tulips * 2.50) * 1.15 - price1;
                            price -= price * 0.2;
                        }
                        else if (numberOfFlowers < 20 && tulips > 7)
                        {
                            double price1 = ((chrysantemums * 2 + roses * 4.1 + tulips * 2.50) * 1.15) * 0.05;
                            price = (chrysantemums * 2 + roses * 4.1 + tulips * 2.50) * 1.15 - price1;
                        }
                        else
                        {
                            price = (chrysantemums * 2 + roses * 4.1 + tulips * 2.50) * 1.15;
                        }
                    }
                    else
                    {
                        if (numberOfFlowers > 20 && tulips <= 7)
                        {
                            price = chrysantemums * 2 + roses * 4.1 + tulips * 2.50;
                            price -= price * 0.2;
                        }
                        else if (numberOfFlowers > 20 && tulips > 7)
                        {
                            double price1 = (chrysantemums * 2 + roses * 4.1 + tulips * 2.50) * 0.10;
                            price = (chrysantemums * 2 + roses * 4.1 + tulips * 2.50) - price1;
                            price -= price * 0.2;
                        }
                        else if (numberOfFlowers < 20 && tulips > 7)
                        {
                            double price1 = (chrysantemums * 2 + roses * 4.1 + tulips * 2.50) * 0.10;
                            price = (chrysantemums * 2 + roses * 4.1 + tulips * 2.50) * 1.15 - price1;
                        }
                        else
                        {
                            price = (chrysantemums * 2 + roses * 4.1 + tulips * 2.50);
                        }
                    }
                    break;
                case "Summer":

                    if (holiday == 'Y')
                    {
                        if (numberOfFlowers > 20)
                        {
                            price = (chrysantemums * 2 + roses * 4.1 + tulips * 2.50) * 1.15;
                            price -= price * 0.2;
                        }
                        else
                        {
                            price = (chrysantemums * 2 + roses * 4.1 + tulips * 2.50) * 1.15;
                        }
                    }
                    else
                    {
                        if (numberOfFlowers > 20)
                        {
                            price = chrysantemums * 2 + roses * 4.1 + tulips * 2.50;
                            price -= price * 0.2;
                        }
                        else
                        {
                            price = (chrysantemums * 2 + roses * 4.1 + tulips * 2.50);
                        }
                    }
                    break;
                case "Winter":

                    if (holiday == 'Y')

                    {
                        if (numberOfFlowers > 20 && roses < 10)
                        {
                            price = (chrysantemums * 3.75 + roses * 4.50 + tulips * 4.15) * 1.15;
                            price -= price * 0.2;
                        }
                        else if (numberOfFlowers > 20 && roses >= 10)
                        {
                            double price1 = ((chrysantemums * 2 + roses * 4.1 + tulips * 2.50) * 1.15) * 0.10;
                            price = (chrysantemums * 2 + roses * 4.1 + tulips * 2.50) * 1.15 - price1;
                            price -= price * 0.2;
                        }
                        else if (numberOfFlowers < 20 && roses >= 10)
                        {
                            double price1 = ((chrysantemums * 2 + roses * 4.1 + tulips * 2.50) * 1.15) * 0.05;
                            price = (chrysantemums * 2 + roses * 4.1 + tulips * 2.50) * 1.15 - price1;
                        }
                        else
                        {
                            price = (chrysantemums * 3.75 + roses * 4.50 + tulips * 4.15) * 1.15;
                        }
                    }
                    else
                    {
                        if (numberOfFlowers > 20 && roses < 10)
                        {
                            price = (chrysantemums * 3.75 + roses * 4.50 + tulips * 4.15);
                            price -= price * 0.2;
                        }
                        else if (numberOfFlowers > 20 && roses >= 10)
                        {
                            double price1 = (chrysantemums * 2 + roses * 4.1 + tulips * 2.50) * 0.10;
                            price = (chrysantemums * 2 + roses * 4.1 + tulips * 2.50) - price1;
                            price -= price * 0.2;
                        }
                        else if (numberOfFlowers < 20 && roses >= 10)
                        {
                            double price1 = (chrysantemums * 2 + roses * 4.1 + tulips * 2.50) * 0.10;
                            price = (chrysantemums * 2 + roses * 4.1 + tulips * 2.50) - price1;
                        }
                        else
                        {
                            price = (chrysantemums * 3.75 + roses * 4.50 + tulips * 4.15);
                        }
                    }
                    break;
                case "Autumn":
                    {
                        if (holiday == 'Y')
                            if (numberOfFlowers > 20)
                            {
                                price = (chrysantemums * 3.75 + roses * 4.50 + tulips * 4.15) * 1.15;
                                price -= price * 0.2;
                            }

                            else
                            {
                                price = (chrysantemums * 3.75 + roses * 4.50 + tulips * 4.15) * 1.15;
                            }

                        else
                        {
                            if (numberOfFlowers > 20)
                            {
                                price = (chrysantemums * 3.75 + roses * 4.50 + tulips * 4.15);
                                price -= price * 0.2;
                            }

                            else
                            {
                                price = (chrysantemums * 3.75 + roses * 4.50 + tulips * 4.15);
                            }
                        }
                    }
                    break;
            }
                    
            Console.WriteLine($"{price + 2:f2}");

        }
    }
}