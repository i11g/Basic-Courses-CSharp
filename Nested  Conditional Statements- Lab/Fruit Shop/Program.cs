using System;

namespace Fruit_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruit=Console.ReadLine();
            string day=Console.ReadLine();
            double quantity=double.Parse(Console.ReadLine());
            bool isError=false;
            double price = 0;

            switch (fruit)
            {
                case "banana":
                    if (day=="Monday"||day=="Tuesday"||day=="Wednesday"||day=="Thursday"||day=="Friday")
                    {
                        price = quantity * 2.50;
                    }
                    else if (day=="Saturday"||day=="Sunday") 
                    {
                        price = quantity * 2.70;
                    }
                    else
                    {
                        isError = true;
                    }
                    break;
                case "apple":
                    if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
                    {
                        price = quantity * 1.20;
                    }
                    else if (day == "Saturday" || day == "Sunday")
                    {
                        price = quantity * 1.25;
                    }
                    else
                    {
                        isError=true;
                    }
                    break;
                case "orange":
                    if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
                    {
                        price = quantity * 0.85;
                    }
                    else if (day == "Saturday" || day == "Sunday")
                    {
                        price = quantity * 0.90;
                    }
                    else
                    {
                        isError = true;
                    }
                    break;
                case "grapefruit":
                    if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
                    {
                        price = quantity * 1.45;
                    }
                    else if (day == "Saturday" || day == "Sunday")
                    {
                        price = quantity * 1.60;
                    }
                    else
                    {
                        isError = true;
                    }
                    break;
                case "kiwi":
                    if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
                    {
                        price = quantity * 2.70;
                    }
                    else if (day == "Saturday" || day == "Sunday")
                    {
                        price = quantity * 3.00;
                    }
                    else
                    {
                        isError = true;
                    }
                    break;
                case "pineapple":
                    if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
                    {
                        price = quantity * 5.50;
                    }
                    else if (day == "Saturday" || day == "Sunday")
                    {
                        price = quantity * 5.60;
                    }
                    else
                    {
                        isError = true;
                    }
                    break;
                case "grapes":
                    if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
                    {
                        price = quantity * 3.85;
                    }
                    else if (day == "Saturday" || day == "Sunday")
                    {
                        price = quantity * 4.20;
                    }
                    else
                    {
                        isError = true;
                    }
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
            if (isError)
            {
                Console.WriteLine("error");
            }
            if (price == 0.0)
            {
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"{price:f2}");
            }
        }
    }
}
