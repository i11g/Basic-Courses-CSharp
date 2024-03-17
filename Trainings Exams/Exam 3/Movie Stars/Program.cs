using System;

namespace Movie_Stars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget=double.Parse(Console.ReadLine());

            string input=Console.ReadLine();
            string name = "";
            double salary = 0;
             

            while(input!="ACTION")
            {
                name = input;
                if (name.Length>16)
                {   
                    
                    budget -= budget * 0.20;
                }
                else if(name.Length<=15) 
                {
                    salary = double.Parse(Console.ReadLine());
                    budget -= salary;
                }
               if(budget < 0)
                {
                    break;
                }
               input = Console.ReadLine();
            }
            if(input=="ACTION")
            {
                Console.WriteLine($"We are left with {budget:f2} leva.");
            }
            else
            {
                Console.WriteLine($"We need {budget:f2} leva for our actors.");
            }
       }
    }
}
