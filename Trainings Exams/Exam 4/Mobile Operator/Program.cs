using System;

namespace Mobile_Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string contractTime=Console.ReadLine();
            string contractType=Console.ReadLine();
            string withMobileInternet=Console.ReadLine();
            int numberOfmonths=int.Parse(Console.ReadLine());
            double price = 0;

            if (contractTime=="one" ) 
            {
                if(contractType=="Small" )
                {
                    if (withMobileInternet=="yes")
                    {
                        price = numberOfmonths * (9.98 + 5.50);
                    }
                    else
                    {
                        price = numberOfmonths * 9.98;
                    }
                }
                else if (contractType=="Middle")
                {
                    if (withMobileInternet == "yes")
                    {
                        price = numberOfmonths * (18.99 + 4.35);
                    }
                    else
                    {
                        price = numberOfmonths * 18.99;
                    }
                }
                else if (contractType == "Large")
                {
                    if (withMobileInternet == "yes")
                    {
                        price = numberOfmonths * (25.98 + 4.35);
                    }
                    else
                    {
                        price = numberOfmonths * 25.98;
                    }
                }
                else if (contractType == "Extralarge")
                {
                    if (withMobileInternet == "yes")
                    {
                        price = numberOfmonths * (35.99 + 3.85);
                    }
                    else
                    {
                        price = numberOfmonths * 35.99;
                    }
                }

            }
            else if(contractTime =="two")
            {
                if (contractType == "Small")
                {
                    if (withMobileInternet == "yes")
                    {
                        price = numberOfmonths * (8.58 + 5.50);
                    }
                    else
                    {
                        price = numberOfmonths * 8.58;
                    }
                }
                else if (contractType == "Middle")
                {
                    if (withMobileInternet == "yes")
                    {
                        price = numberOfmonths * (17.09 + 4.35);
                    }
                    else
                    {
                        price = numberOfmonths * 17.09;
                    }
                }
                else if (contractType == "Large")
                {
                    if (withMobileInternet == "yes")
                    {
                        price = numberOfmonths * (23.59 + 4.35);
                    }
                    else
                    {
                        price = numberOfmonths * 23.59;
                    }
                }
                else if (contractType == "Extralarge")
                {
                    if (withMobileInternet == "yes")
                    {
                        price = numberOfmonths * (31.79 + 3.85);
                    }
                    else
                    {
                        price = numberOfmonths * 31.79;
                    }
                }

                if (contractTime=="two")
                {
                    price -= price * 0.0375;
                }

            }
            Console.WriteLine($"{price:f2} lv.");
        }

        }
    }



