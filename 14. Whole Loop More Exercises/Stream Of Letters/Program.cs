using System;

namespace Stream_Of_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char letter = char.Parse(Console.ReadLine());

            while (letter != '%' || letter != '$' || letter != '!' || letter != '@' || letter != '#' || letter != '^' || letter != '&'||letter != '*' || letter != '(' || letter != ')' || letter != '{' || letter != '}' || letter != '/' || letter != '?')  
            {
                Console.WriteLine(letter);
            }
        }
    }
}
