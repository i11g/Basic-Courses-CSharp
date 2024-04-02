using System;

namespace Triangle_area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double side=double.Parse(Console.ReadLine());   
            double heigth=double.Parse(Console.ReadLine());

            double area = side * heigth / 2;

            Console.WriteLine($"{area:F2}");

        }
    }
}
