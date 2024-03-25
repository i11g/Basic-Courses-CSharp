using System;

namespace Bike_Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberJuniors=int.Parse(Console.ReadLine());
            int numberSeniors=int.Parse(Console.ReadLine());
            string typeTrail=Console.ReadLine();
            double tax = 0;

            switch (typeTrail)
            {
                case "trail":
                    if (numberJuniors > 0)
                    {
                        tax = numberJuniors * 5.50 + numberSeniors * 7;
                    }
                   break;
                case "cross-country":
                    int numbers = numberJuniors + numberSeniors;
                    
                    if (numbers >= 50)
                    {
                       double tax1 = numberJuniors * 8 + numberSeniors * 9.50; 
                        tax=tax1- tax1 * 0.25;
                    }
                    else 
                    {
                        tax = numberJuniors * 8 + numberSeniors * 9.50;
                    }
                    break;
                case "downhill":
                    if (numberJuniors > 0)
                    {
                        tax = numberJuniors * 12.25+numberSeniors * 13.75;
                    }
                     break;
                case "road":
                    if (numberJuniors > 0)
                    {
                        tax = numberJuniors * 20+ numberSeniors * 21.50;
                    }
                    break;
            
            }
            tax -= tax * 0.05;
            Console.WriteLine($"{tax:f2}");
        }
    }
}
