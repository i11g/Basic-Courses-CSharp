using System;

namespace Barcode_Generator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startDiapazon=int.Parse(Console.ReadLine());
            int endDiapazon=int.Parse(Console.ReadLine());

            for (int i = startDiapazon; i <=endDiapazon; i++)
            {
                for (int j = startDiapazon; j <=endDiapazon; j++)
                {
                    for (int k = startDiapazon; k <=endDiapazon; k++)
                    {
                        for (int l = startDiapazon; l <=endDiapazon; l++)
                        {
                            if(i%2!=0&&j%2!=0&&k%2!=0&&l%2!=0)
                            {
                                Console.WriteLine($"{i}{j}{k}{l}");
                            }
                        }
                    }
                }
            }
        }
    }
}
