using System;

namespace Ski_Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int numberOfDays=int.Parse(Console.ReadLine());
            string typeOfRoom=Console.ReadLine();
            string grade=Console.ReadLine();
            double budget = 0;
            int numberOfNigths=(numberOfDays-1);

            
            if (typeOfRoom == "room for one person")
            {
                budget = numberOfNigths * 18;
            }
            else if (typeOfRoom == "apartment")
            {
                if (numberOfNigths < 10)
                {
                    budget = (numberOfNigths * 25) - (numberOfNigths * 25 * 0.3);
                }
                else if (numberOfNigths < 15)
                {
                    budget = (numberOfNigths * 25) - (numberOfNigths * 25 * 0.35);
                }
                else
                {
                    budget = (numberOfNigths * 25) - (numberOfNigths * 25 * 0.5);
                }
            }
            else 
            {
                if (numberOfNigths < 10)
                {
                    budget = (numberOfNigths * 35) - (numberOfNigths * 35 * 0.1);
                }
                else if (numberOfNigths < 15)
                {
                    budget = (numberOfNigths * 35) - (numberOfNigths * 35 * 0.15);
                }
                else
                {
                    budget = (numberOfNigths * 35) - (numberOfNigths * 35 * 0.2);
                }

            }
            if (grade=="positive")
            {
                budget += budget * 0.25;
            }
            else
            {
                budget -= budget * 0.10;

            }
            Console.WriteLine($"{budget:f2}");
        }
    }
}
 