using System;

namespace Train_the_Trainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbersJury = int.Parse(Console.ReadLine());
            string namePresentation;
            double totalaverageGrade = 0;
            int numbersOfPresentations = 0;

            for (int i = 1; i <= numbersJury; i++)
            {
                namePresentation= Console.ReadLine();
                string input = Console.ReadLine();
                double grade;
                double averageGrade = 0;
                double numberofGrades = 0;
                while (input != "Finish")
                {
                    grade = double.Parse(input);
                    averageGrade += grade;
                    numberofGrades++;
                    
                    if(numberofGrades==numbersJury)
                    {
                        break;
                    }
                    input = Console.ReadLine();

                }
                if (input == "Finish")
                {
                    break;
                }
                else if (numberofGrades== numbersJury)
                    {
                    Console.WriteLine($" {namePresentation} - {averageGrade / numbersJury}");
                    totalaverageGrade += averageGrade;
                    numbersOfPresentations++;
                }
            }
            Console.WriteLine($"Student's final assessment is {totalaverageGrade / numbersOfPresentations}.");
        }
    }
}
