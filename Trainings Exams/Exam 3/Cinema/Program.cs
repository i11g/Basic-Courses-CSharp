using System;

namespace Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfSeats = int.Parse(Console.ReadLine());
            string input=Console.ReadLine();
            double numberOfPeople = 0;
            double income = 0;
            double countNumber = 0;
            bool isFull = false;
            
            while (input!="Movie time!")
            {
                numberOfPeople=int.Parse(input);

                countNumber += numberOfPeople;
                if (countNumber >numberOfSeats)
                {   
                    isFull = true;
                    break;
                }
                
                if (numberOfPeople%3== 0)
                {
                    income += numberOfPeople * 5 - 5;

                }
                else
                {
                    income += numberOfPeople * 5;
                }
                input = Console.ReadLine();
            }
            if (isFull)
            {
                Console.WriteLine($"The cinema is full.");
                Console.WriteLine($"Cinema income - {income} lv.");
            }

            if(input=="Movie time!") 
            {
                Console.WriteLine($"There are {numberOfSeats - countNumber} seats left in the cinema.");
                Console.WriteLine($"Cinema income - {income} lv.");

            }
        }
    }
}
