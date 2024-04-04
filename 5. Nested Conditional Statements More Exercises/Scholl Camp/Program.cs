using System;

namespace Scholl_Camp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string season=Console.ReadLine();
            string typeGroup=Console.ReadLine();
            int numberOfStudents=int.Parse(Console.ReadLine()); 
            int numberOfNigths=int.Parse(Console.ReadLine());
            double price = 0;
            string sport = string.Empty;

            if (season=="Winter")
            {

                if (typeGroup == "boys" )

                {
                    price = numberOfStudents * numberOfNigths * 9.60;
                    sport = "Judo";

                    if (numberOfStudents>=10&&numberOfStudents<20)
                    {
                        price -= price * 0.05;
                    }
                    else if (numberOfStudents <50)
                    {
                        price -= price * 0.15;
                    }
                    else if ( numberOfStudents >=50 )
                    {
                        price -= price * 0.5;
                    }
                }
                else if(typeGroup=="girls") 
                {
                    price = numberOfStudents * numberOfNigths * 9.60;
                    sport = "Gymnastics";
                    if (numberOfStudents >= 10 && numberOfStudents < 20)
                    {
                        price -= price * 0.05;
                    }
                    else if (numberOfStudents < 50&&numberOfStudents>=20)
                    {
                        price -= price * 0.15;
                    }
                    else if (numberOfStudents >= 50)
                    {
                        price -= price * 0.5;
                    }
                }
                else
                {
                    price = numberOfStudents * numberOfNigths * 10.00;
                    sport = "Ski";
                    if (numberOfStudents >= 10 && numberOfStudents < 20)
                    {
                        price -= price * 0.05;
                    }
                    else if (numberOfStudents < 50 && numberOfStudents >= 20)
                    {
                        price -= price * 0.15;
                    }
                    else if (numberOfStudents >= 50)
                    {
                        price -= price * 0.5;
                    }

                }
            }
            if (season == "Spring")
            {

                if (typeGroup == "boys")

                {
                    price = numberOfStudents * numberOfNigths * 7.20;
                    sport = "Tennis";

                    if (numberOfStudents >= 10 && numberOfStudents < 20)
                    {
                        price -= price * 0.05;
                    }
                    else if (numberOfStudents < 50 && numberOfStudents >= 20)
                    {
                        price -= price * 0.15;
                    }
                    else if (numberOfStudents >= 50)
                    {
                        price -= price * 0.5;
                    }
                }
                else if (typeGroup == "girls")
                {
                    price = numberOfStudents * numberOfNigths * 7.20;
                    sport = "Athletics";
                    if (numberOfStudents >= 10 && numberOfStudents < 20)
                    {
                        price -= price * 0.05;
                    }
                    else if (numberOfStudents < 50 && numberOfStudents >= 20)
                    {
                        price -= price * 0.15;
                    }
                    else if (numberOfStudents >= 50)
                    {
                        price -= price * 0.5;
                    }
                }
                else
                {
                    price = numberOfStudents * numberOfNigths * 9.50;
                    sport = "Cycling";
                    if (numberOfStudents >= 10 && numberOfStudents < 20)
                    {
                        price -= price * 0.05;
                    }
                    else if (numberOfStudents < 50 && numberOfStudents >= 20)
                    {
                        price -= price * 0.15;
                    }
                    else if (numberOfStudents >= 50)
                    {
                        price -= price * 0.5;
                    }

                }
            }
            if (season == "Summer")
            {

                if (typeGroup == "boys")

                {
                    price = numberOfStudents * numberOfNigths * 15.00;
                    sport = "Football";

                    if (numberOfStudents >= 10 && numberOfStudents < 20)
                    {
                        price -= price * 0.05;
                    }
                    else if (numberOfStudents < 50 && numberOfStudents >= 20)
                    {
                        price -= price * 0.15;
                    }
                    else if (numberOfStudents >= 50)
                    {
                        price -= price * 0.5;
                    }
                }
                else if (typeGroup == "girls")
                {
                    price = numberOfStudents * numberOfNigths * 9.60;
                    sport = "Volleyball";
                    if (numberOfStudents >= 10 && numberOfStudents < 20)
                    {
                        price -= price * 0.05;
                    }
                    else if (numberOfStudents < 50 && numberOfStudents >= 20)
                    {
                        price -= price * 0.15;
                    }
                    else if (numberOfStudents >= 50)
                    {
                        price -= price * 0.5;
                    }
                }
                else
                {
                    price = numberOfStudents * numberOfNigths * 20.00;
                    sport = "Swimming";
                    if (numberOfStudents >= 10 && numberOfStudents < 20)
                    {
                        price -= price * 0.05;
                    }
                    else if (numberOfStudents < 50 && numberOfStudents >= 20)
                    {
                        price -= price * 0.15;
                    }
                    else if (numberOfStudents >= 50)
                    {
                        price -= price * 0.5;
                    }

                }
            }
            Console.WriteLine($"{sport} {price:f2} lv.");

        }
    }
}
