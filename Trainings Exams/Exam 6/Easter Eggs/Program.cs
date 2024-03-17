using System;

namespace Easter_Eggs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfEggs=int.Parse(Console.ReadLine());
            int numberRedEggs = 0;
            int numberOrangeEggs = 0;
            int numberBlueEggs = 0;
            int numberGreenEggs = 0;
            int totalEggs = 0;
            int MaxEggs =0;
            string colorMaxEggs = "";

            for (int i = 1; i <=numberOfEggs; i++)
            {
                string color = Console.ReadLine();
                totalEggs++;
                if(color =="red")
                {
                    numberRedEggs++;
                }
                else if (color == "orange")
                {
                    numberOrangeEggs++;
                }
                else if (color == "blue")
                {
                    numberBlueEggs++;
                }
                else if (color == "orange")
                {
                    numberGreenEggs++;
                }
                if(numberRedEggs>numberOrangeEggs&&numberOrangeEggs>numberBlueEggs&&numberBlueEggs>numberGreenEggs)
                {
                    MaxEggs=numberRedEggs;
                    colorMaxEggs = "red";
                }
                else if(numberOrangeEggs >numberRedEggs&& numberRedEggs > numberBlueEggs && numberBlueEggs > numberGreenEggs)
                {
                    MaxEggs = numberOrangeEggs;
                    colorMaxEggs = "orange";
                }
                else if (numberBlueEggs > numberRedEggs && numberRedEggs > numberOrangeEggs && numberOrangeEggs > numberGreenEggs)
                {
                    MaxEggs = numberBlueEggs;
                    colorMaxEggs = "blue";
                }
                else if (numberGreenEggs > numberRedEggs && numberRedEggs > numberOrangeEggs && numberOrangeEggs > numberBlueEggs)
                {
                    MaxEggs = numberGreenEggs;
                    colorMaxEggs = "green";
                }


            }
            Console.WriteLine($"Red eggs: {numberRedEggs}");
            Console.WriteLine($"Orange eggs: {numberOrangeEggs}");
            Console.WriteLine($"Blue eggs: {numberBlueEggs}");
            Console.WriteLine($"Green eggs: {numberGreenEggs}");
            Console.WriteLine($"Max eggs: {MaxEggs} -> {colorMaxEggs}");
        }
    }
}
