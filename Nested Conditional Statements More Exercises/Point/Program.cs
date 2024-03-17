using System;
using System.ComponentModel;

namespace Point
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x1=int.Parse(Console.ReadLine());
            int y1=int.Parse(Console.ReadLine());
            int x2=int.Parse(Console.ReadLine());
            int y2=int.Parse(Console.ReadLine());
            int x=int.Parse(Console.ReadLine());
            int y=int.Parse(Console.ReadLine());

            if (x == x1)
            {
                if (y >=y1&&y<=y2) 
                {
                    Console.WriteLine("Border");
                }
            }
            else if (x == x2)
            {
                if (y >= y1 && y <= y2)
                {
                    Console.WriteLine("Border");
                }
            }
            else if (y == y2)
            {
                if (y >= x1 && y <= x2)
                {
                    Console.WriteLine("Border");
                }
            }
            else if (y == y1)
            {
                if (y >= x1 && y <= x2)
                {
                    Console.WriteLine("Border");
                }
            }
            else
            {
                Console.WriteLine("Inside / Outside");
            }
        }
    }
}
