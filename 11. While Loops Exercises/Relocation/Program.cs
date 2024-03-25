using System;

namespace Relocation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width=int.Parse(Console.ReadLine());
            int length=int.Parse(Console.ReadLine());
            int heigth=int.Parse(Console.ReadLine());

            int space=width*length*heigth;
            string input=Console.ReadLine();
            int numberOfBoxes = 0;

            while(input!="Done")
            {
                int boxes = int.Parse(input);
                numberOfBoxes+=boxes;
                if(numberOfBoxes > space)
                {
                    break;
                }
                input = Console.ReadLine();
            }
            if (numberOfBoxes > space)
            {
                Console.WriteLine($"No more free space! You need {numberOfBoxes - space} Cubic meters more.");
            }
            else if(input=="Done")
            {
                Console.WriteLine($"{space-numberOfBoxes} Cubic meters left.");
            }

        }
    }
}
