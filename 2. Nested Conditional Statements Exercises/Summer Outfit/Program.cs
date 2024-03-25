using System;

namespace Summer_Outfit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int gradius=int.Parse(Console.ReadLine());
            string typeOfDay=Console.ReadLine();

            if (typeOfDay =="Morning")
            {
                if (gradius<=18)
                {
                    Console.WriteLine($"It's {gradius} degrees, get your {"Sweatshirt"} and {"Sneakers"}.");
                }
                else if (gradius <= 24)
                {
                    Console.WriteLine($"It's {gradius} degrees, get your {"Shirt"} and {"Moccasins"}.");
                }
                else if (gradius >= 25)
                {
                    Console.WriteLine($"It's {gradius} degrees, get your {"T-Shirt"} and {"Sandals"}.");
                }
            }
            else if (typeOfDay == "Afternoon")
            {
                if (gradius<= 18)
                {
                    Console.WriteLine($"It's {gradius} degrees, get your {"Shirt"} and {"Moccasins"}.");
                }
                else if (gradius <= 24)
                {
                    Console.WriteLine($"It's {gradius} degrees, get your {"T-Shirt"} and {"Sandals"}.");
                }
                else if (gradius >= 25)
                {
                    Console.WriteLine($"It's {gradius} degrees, get your {"Swim Suit"} and {"Barefoot"}.");
                }
            }
            else if (typeOfDay == "Evening")
            {
                if (gradius <= 18)
                {
                    Console.WriteLine($"It's {gradius} degrees, get your {"Shirt"} and {"Moccasins"}.");
                }
                else if (gradius <= 24)
                {
                    Console.WriteLine($"It's {gradius} degrees, get your {"Shirt"} and {"Moccasins"}.");
                }
                else if (gradius >= 25)
                {
                    Console.WriteLine($"It's {gradius} degrees, get your {"Shirt"} and {"Moccasins"}.");
                }
            }
        }
    }
}
