using System;

namespace Cinema_Tickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input=Console.ReadLine();
            string name = "";
            
            double freeSpaces = 0;
            int student = 0;
            int standart = 0;
            int kids = 0;
            double total = 0;
            bool isFull = false;

            while(input!="Finish")
            {
                name= input;
                
                freeSpaces=int.Parse(Console.ReadLine());
                string command=Console.ReadLine();
                string type = "";
                while (command!="End")
                {
                    type=command;
                    if (type=="student")
                    {
                        student++;
                        freeSpaces--;
                    }
                    else if (type=="standard")
                    {
                        standart++;
                        freeSpaces--;
                    }
                    else if (type=="kid")
                    {
                        kids++;
                        freeSpaces--;
                    }
                    if (freeSpaces==0)
                    {  
                        isFull = true;
                        break;
                    }
                    total = standart + student + kids;
                    command= Console.ReadLine();
                }
                if(command=="End")
                {
                    Console.WriteLine($"{name}-{total / freeSpaces * 100:f2} full");
                }
                else if(isFull)
                {
                    break;
                }
             input=Console.ReadLine();
            }
            if (input=="Finish"||isFull)
            {
                Console.WriteLine($"Total tickets: {total}");
                Console.WriteLine($"{student/total*100:f2}% student tickets.");
                Console.WriteLine($"{standart/total*100:f2}% student tickets.");
                Console.WriteLine($"{kids/total*100:f2}% student tickets.");
            }
        }
    }
}
