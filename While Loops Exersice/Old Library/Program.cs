using System;

namespace Old_Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string searchedBook = Console.ReadLine();
            string input = Console.ReadLine();
            int sumBooks = 0;
            
            while (input != "No More Books") 
            {    
                                
                if(input==searchedBook)
                {
                    break;
                }
                
                sumBooks++;

                input = Console.ReadLine();

            }
            if (input == searchedBook)
            {
                Console.WriteLine($"You checked {sumBooks} books and found it.");
            }
            else
            {
                Console.WriteLine($"The book you search is not here!");
                Console.WriteLine($"You checked {sumBooks} books.");
            }
        }
    }
}
