using System;

namespace Building
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfFloors = int.Parse(Console.ReadLine());
            int numberOfRooms = int.Parse(Console.ReadLine());

            for (int numberOfF = numberOfFloors; numberOfF >= 1; numberOfF--)
            {
                for (int numberOfR = 0; numberOfR < numberOfRooms; numberOfR++)
                {

                    if (numberOfF == numberOfFloors)
                    {
                        Console.Write($"{"L"}{numberOfF}{numberOfR} ");
                    }
                    else if (numberOfF % 2 == 0)
                    {
                        Console.Write($"{"O"}{numberOfF}{numberOfR} ");
                    }
                    else if (numberOfF % 2 != 0)
                    {
                        Console.Write($"{"A"}{numberOfF}{numberOfR} ");
                    }
                }

                Console.WriteLine();
            }

        }
    }
}
