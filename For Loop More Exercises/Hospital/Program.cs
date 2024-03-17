using System;

namespace Hospital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int period = int.Parse(Console.ReadLine());
            int treatedPatiants = 0;
            int untreatedPatiants = 0;
            int sumuntreatedPatiants = 0;
            int days = 0;

            for (int i = 0; i < period; i++)
            {
                int patiants = int.Parse(Console.ReadLine());
                days++;

               if (sumuntreatedPatiants > treatedPatiants && days >= 3)
                {
                    if (patiants <= 8)
                    {
                        treatedPatiants += patiants;

                    }
                    else
                    {
                        treatedPatiants += 8;

                        untreatedPatiants = patiants - 8;
                        sumuntreatedPatiants += untreatedPatiants;
                    }

                }

               else if (patiants <= 7)
                {
                    treatedPatiants += patiants;

                }
                else if (patiants > 7)
                {
                    treatedPatiants += 7;

                    untreatedPatiants = patiants - 7;
                    sumuntreatedPatiants += untreatedPatiants;

                }
                 
                
            }
            Console.WriteLine($"Treated patients: {treatedPatiants}.");
            Console.WriteLine($"Untreated patients: {sumuntreatedPatiants}.");
        }
    }
}
