using System;

namespace Number_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int targetSum=int.Parse(Console.ReadLine());
            string input=Console.ReadLine();
            string service;
            int income = 0;
            bool isReach=false;

            while(input!= "closed")
            {
                service = input;
                string type= Console.ReadLine(); 
                if(service == "haircut")
                {
                    if(type == "mens")
                    {
                        income += 15;
                    }
                    else if(type== "ladies") 
                    { 
                        income += 20;
                    }
                    else
                    {
                        income += 10;
                    }
                }
                else if (service == "color")
                {
                    if(type == "touch up")
                    {
                        income += 20;
                    }
                    else
                    {
                        income += 30;
                    }
                }
                if(income>=targetSum)
                {   
                    isReach = true;
                    break;
                }
                input=Console.ReadLine();
            }
            if(isReach)
            {
                Console.WriteLine($"You have reached your target for the day!");
                Console.WriteLine($"Earned money: {income}lv.");
            }
            if(input=="closed")
            {
                Console.WriteLine($"Target not reached! You need {(targetSum - income)}lv. more.");
                Console.WriteLine($"Earned money: {income}lv.");
            }
        }
    }
}
