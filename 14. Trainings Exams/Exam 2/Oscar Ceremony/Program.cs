using System;
using System.Xml.Schema;

namespace Oscar_Ceremony
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rent=int.Parse(Console.ReadLine());

            double statuetki=rent-rent*0.30; 
            double catering=statuetki-statuetki*0.15;
            double volume = catering * 1.00 / 2.00;

            double total = rent + statuetki + catering + volume;
            Console.WriteLine($"{total:f2}") ;
        }
    }
}
