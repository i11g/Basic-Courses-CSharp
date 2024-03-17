using System;

namespace Journey1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget=double.Parse(Console.ReadLine());
            string season=Console.ReadLine();
            string destination = string.Empty;
            string type = string.Empty;

            switch (season)
            {
                case "summer":

                    if (budget <= 100)
                    {
                        destination = "Bulgaria";
                        type = "Camp";
                        budget *= 0.3;
                    }
                    else if (budget <= 1000)
                    {
                        destination = "Balkans";
                        type = "Camp";
                        budget *= 0.4;
                    }
                    else
                    {
                        destination = "Europe";
                        type = "Hotel";
                        budget *= 0.9;

                    }
                    break;
                case "winter":

                    if (budget <= 100)
                    {
                        destination = "Bulgaria";
                        type = "Hotel";
                        budget *= 0.7;
                    }
                    else if (budget <= 1000)
                    {
                        destination = "Balkans";
                        type = "Hotel";
                        budget *= 0.8;
                    }
                    else
                    {
                        destination = "Europe";
                        type = "Hotel";
                        budget *= 0.9;

                    }
                    break;
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{type} - {budget:f2}");
  
         

        }
    }
}
