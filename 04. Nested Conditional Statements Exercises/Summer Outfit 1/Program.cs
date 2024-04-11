using System;

namespace Summer_Outfit_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int gradius=int.Parse(Console.ReadLine());
            string typeDay=Console.ReadLine();
            string clothes = string.Empty;
            string shoes = string.Empty;

            if (typeDay =="Evening")
            {
                clothes = "Shirt";
                shoes = "Moccasins";
            }
            else if (typeDay =="Afternoon")
            {
                if (gradius<=18)
                {
                    clothes = "Shirt";
                    shoes = "Moccasins";
                }
                else if (gradius<=24)
                {
                    clothes = "T-Shirt";
                    shoes = "Sandals";
                }
                else
                {
                    clothes = "Swim Suit";
                    shoes = "Barefoot";

                }
            }
            else
            {
                if (gradius <= 18)
                {
                    clothes = "Sweatshirt";
                    shoes = "Sneakers";
                }
                else if (gradius <= 24)
                {
                    shoes = "Moccasins";
                    clothes = "Shirt";
                }
                else
                {
                    clothes = "T-Shirt";
                    shoes = "Sandals";

                }
            }
            Console.WriteLine($"It's {gradius} degrees, get your {clothes} and {shoes}");
        }
    }
}
