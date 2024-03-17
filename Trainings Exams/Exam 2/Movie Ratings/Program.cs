using System;

namespace Movie_Ratings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfFilms=int.Parse(Console.ReadLine());
            string name = "";
            double raiting = 0;
            double maxraiting =1.00;
            double minraiting = 10.00;
            double totalRaiting = 0;
            string movieMaxRaiting = "";
            string movieMinRaiting = "";

            for (int i = 1; i <=numberOfFilms; i++)
            {
                name=Console.ReadLine();
                raiting = double.Parse(Console.ReadLine());
                if(raiting > maxraiting)
                {
                    maxraiting = raiting;
                    movieMaxRaiting=name;
                }
                if(raiting < minraiting)
                {
                    minraiting = raiting;
                    movieMinRaiting=name;
                }
                totalRaiting+= raiting;
            }
            Console.WriteLine($"{movieMaxRaiting} is with highest rating: {maxraiting}");
            Console.WriteLine($"{movieMinRaiting} is with highest rating: {minraiting}");
            Console.WriteLine($"Average rating: {totalRaiting/(double)numberOfFilms:f1}");
        }
    }
}
