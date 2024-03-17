using System;
using System.Reflection;

namespace Cinema_Vaucher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vaucherSum=int.Parse(Console.ReadLine());
            string input=Console.ReadLine();
            int ticketPrice = 0;
            int productPrice = 0;
            int tickets = 0;
            int products = 0;

            while(input!="End")
            {
                
                if(input.Length>8)
                {
                    char one = input[0]; 
                    char two = input[1];
                    ticketPrice = (char)(one + two);
                    if(vaucherSum>ticketPrice)
                    {
                        vaucherSum -= ticketPrice;
                        tickets++;
                    }
                    else if(vaucherSum<ticketPrice) 
                    {
                        break;
                    }
                }
                else if (input.Length<=8) 
                {
                    char first = input[0];
                    productPrice=first; 
                    if (vaucherSum > productPrice)
                    {
                        vaucherSum -= productPrice;
                        products++;
                    }
                    else if (productPrice>vaucherSum)
                    {
                        break;
                    }
                }
                input=Console.ReadLine();
                
            }
            Console.WriteLine($"{tickets}");
            Console.WriteLine($"{products}");
        }
    }
}
