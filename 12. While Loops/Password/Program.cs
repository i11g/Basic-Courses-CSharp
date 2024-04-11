using System;

namespace Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string userName=Console.ReadLine();
           string password=Console.ReadLine(); 

            string input=Console.ReadLine();

            while (input!=password)
            {
               // Console.WriteLine("Please enter new password");
                                
                input = Console.ReadLine();
            }
            
            Console.WriteLine($"Welcome {userName}!");
                
            
        }
    }
}
