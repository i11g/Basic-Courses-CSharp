using System;

namespace Trade_Commisions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            double commissions = 0;
                                    
           if (sales >= 0 && sales <= 500)
            {
                if (city == "Sofia")
                {
                    commissions = sales * 0.05;
                }
                else if (city == "Varna")
                {
                    commissions = sales * 0.045;
                }
                else if (city == "Plovdiv")
                {
                    commissions = sales * 0.055;
                }
            }
            else if (sales > 500 && sales <= 1000)
            {
                if (city == "Sofia")
                {
                    commissions = sales * 0.07;
                }
                else if (city == "Varna")
                {
                    commissions = sales * 0.075;
                }
                else if (city == "Plovdiv")
                {
                    commissions = sales * 0.08;
                }
            }
            else if (sales > 1000 && sales <= 10000)
            {
                if (city == "Sofia")
                {
                    commissions = sales * 0.08;
                }
                else if (city == "Varna")
                {
                    commissions = sales * 0.1;
                }
                else if (city == "Plovdiv")
                {
                    commissions = sales * 0.12;
                }

            }
            else if (sales > 10000)
            {
                if (city == "Sofia")
                {
                    commissions = sales * 0.12;
                }
                else if (city == "Varna")
                {
                    commissions = sales * 0.13;
                }
                else if (city == "Plovdiv")
                {
                    commissions = sales * 0.145;
                }
            }

            if (city != "Sofia"||sales<0)
            {
                if (city != "Plovdiv"||sales<0)
                {
                    if (city != "Varna"||sales<0)
                    {
                        Console.WriteLine("error");

                    }
                }
            }
            if (commissions == 0.0)
            {
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"{commissions:f2}");
            }
    }
    }
}
