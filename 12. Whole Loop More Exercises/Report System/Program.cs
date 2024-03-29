using System;

namespace Report_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum=double.Parse(Console.ReadLine());
            string input=Console.ReadLine();
            double collectedSum = 0;
            double countPayment = 0;
            double paymentsInCard = 0;
            double paymentsInCash = 0;
                double countPaymentInCash = 0;
                double countPaymentInCard = 0;
            


            while (input!="End") 
            {
                double payment=double.Parse(input);
                countPayment++;
                
                if (countPayment%2==0)  
                {
                    if (payment < 10)
                    {
                        Console.WriteLine($"Error in transaction!");
                    }
                    else
                    {
                        Console.WriteLine($"Product sold!");
                        paymentsInCard +=payment;
                        countPaymentInCard++;
                    }
                }
                else 
                {   if (payment > 100)
                    {
                        Console.WriteLine($"Error in transaction!");
                    }
                    else
                    {
                        Console.WriteLine($"Product sold!");
                        paymentsInCash +=payment;
                        countPaymentInCash++;
                    }
                }
                collectedSum = paymentsInCard + paymentsInCash;

                if (collectedSum>sum)
                {
                    break;
                }
                input= Console.ReadLine();
            }
            if (input=="End")
            {
                Console.WriteLine($"Failed to collect required money for charity.");
            }
            else if (countPaymentInCash>0||countPaymentInCard>0) 
            {
                Console.WriteLine($"Average CS: {(double)paymentsInCash / countPaymentInCash:f2}");
                Console.WriteLine($"Average CC: {(double)paymentsInCard / countPaymentInCard:f2}");
            }
        }
    }
}
