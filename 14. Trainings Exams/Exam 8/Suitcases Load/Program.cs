using System;

namespace Suitcases_Load
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double capacity=double.Parse(Console.ReadLine());
            string input=Console.ReadLine();
            double size=0;
            int numberOgLaguages = 0;

            while(input!="End")
            {
                size = double.Parse(input);
                numberOgLaguages++;
                capacity-=size;
                if(numberOgLaguages==3)
                {
                    capacity -= size * 0.2;
                }
                
                if (capacity<=0)
                {
                    break;
                }
                input = Console.ReadLine();

            }
            if(capacity<=0)
            {
                Console.WriteLine($"No more space!");
                Console.WriteLine($"Statistic: {numberOgLaguages} suitcases loaded.");
            }
            if(input=="End")
            {
                Console.WriteLine($"Congratulations! All suitcases are loaded!");
                Console.WriteLine($"Statistic: {numberOgLaguages} suitcases loaded.");

            }

                
        }
    }
}
