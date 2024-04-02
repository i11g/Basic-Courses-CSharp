using System;

namespace Vacation_Book_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPages=int.Parse(Console.ReadLine());
            int pagesPerHour=int.Parse(Console.ReadLine());
            int days=int.Parse(Console.ReadLine());

            int hours = numberOfPages / pagesPerHour;
            int hoursDay=hours/days;

            Console.WriteLine(hoursDay);

        }
    }
}
