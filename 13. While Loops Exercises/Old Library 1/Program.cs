using System;
using static System.Reflection.Metadata.BlobBuilder;

namespace Old_Library_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string searchedBook=Console.ReadLine();
            string input=Console.ReadLine();
            bool isFound = false;
            int sum = 0;

            while(input!="No More Books")
            {
                if (searchedBook==input)
                {
                    isFound = true;
                    break;
                }
                sum++;
                input = Console.ReadLine();

            }
            if (isFound) 
            {
                Console.WriteLine($"You checked {sum} books and found it.");
            }
            else
            {
                Console.WriteLine($"The book you search is not here!");
                Console.WriteLine($"You checked {sum} books.");
            }
        }
    }
}
