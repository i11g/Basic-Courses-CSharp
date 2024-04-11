using System;

namespace Training_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double height=double.Parse(Console.ReadLine());
            double width=double.Parse(Console.ReadLine());

            double desks = (int)((width * 100) - 100) / 70;
            double rows = (int)(height * 100) / 120;

            int numberSeats=(int)(desks*rows)-3;
            Console.WriteLine(numberSeats);
        }
    }
}
