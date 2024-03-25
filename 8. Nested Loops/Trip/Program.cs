using System;

namespace Trip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input=Console.ReadLine();
            double budget;
            string destination;
            
           while(input!="End")
            {
                destination = input;
                budget = double.Parse(Console.ReadLine());
                double savedMoney=0;
                double totalSavedMoney = 0;
                               
                while (totalSavedMoney < budget)
                {
                    savedMoney = double.Parse(Console.ReadLine());
                    totalSavedMoney+= savedMoney;
                   
                                        
                }
                if(totalSavedMoney >=budget)
                {
                    Console.WriteLine($"Going to {destination}!");
                    
                }
                input = Console.ReadLine();
            }
            

        }
    }
}
