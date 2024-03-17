using System;

namespace Cinema_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type=Console.ReadLine();
            int numberRows=int.Parse(Console.ReadLine());
            int numberColumns=int.Parse(Console.ReadLine());

            double income = numberColumns * numberRows;
            

            if (type=="Premiere")
            {
                income *= 12;
            }
            else if (type=="Normal")
            {
                income *= 7.50;
            }
            else
            {
                income*= 5;
            }
            Console.WriteLine("{0:f2} leva", income);

        }
    }
}
