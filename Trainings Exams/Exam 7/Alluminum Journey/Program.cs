using System;
using System.Reflection.Metadata.Ecma335;

namespace Alluminum_Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfDograma=int.Parse(Console.ReadLine());
            string type=Console.ReadLine();
            string wayOfDelivery=Console.ReadLine();
            double price = 0;

            if(type== "90X130")
            {
                if(numberOfDograma<=30)
                {
                    price = numberOfDograma * 110;
                }
                else if(numberOfDograma>30&&numberOfDograma<=60)
                {
                    price = numberOfDograma * 110 - numberOfDograma * 110 * 0.05;
                }
                else
                {
                    price=numberOfDograma*110-numberOfDograma*110*0.08;
                }
            }
            else if (type== "100X150")
            {
                if (numberOfDograma <= 40)
                {
                    price = numberOfDograma * 140;
                }
                else if (numberOfDograma > 40 && numberOfDograma <= 80)
                {
                    price = numberOfDograma * 140 - numberOfDograma * 140 * 0.06;
                }
                else
                {
                    price = numberOfDograma * 140 - numberOfDograma * 140 * 0.10;
                }
            }
            else if (type == "130X180")
            {
                if (numberOfDograma <= 20)
                {
                    price = numberOfDograma * 190;
                }
                else if (numberOfDograma > 20 && numberOfDograma <= 50)
                {
                    price = numberOfDograma * 190 - numberOfDograma * 190 * 0.07;
                }
                else
                {
                    price = numberOfDograma * 190 - numberOfDograma * 190 * 0.12;
                }
            }
            else if (type == "200X300")
            {
                if (numberOfDograma <= 25)
                {
                    price = numberOfDograma * 250;
                }
                else if (numberOfDograma > 25 && numberOfDograma <= 50)
                {
                    price = numberOfDograma * 250 - numberOfDograma * 250 * 0.09;
                }
                else
                {
                    price = numberOfDograma * 250 - numberOfDograma * 250 * 0.14;
                }
            }
            if (wayOfDelivery == "With delivery")
            {
                price += 60;
            }
            if(numberOfDograma>99)
            {
                price -= price * 0.04;
            }
            if (numberOfDograma < 10)
            {
                Console.WriteLine($"Invalid order");

            }
            else
            {
                Console.WriteLine($"{price:f2} BGN");
            }
        }
    }
}
