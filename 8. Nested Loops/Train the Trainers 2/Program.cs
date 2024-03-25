using System;

namespace Train_the_Trainers_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int membersOfJury=int.Parse(Console.ReadLine());
            string nameOfPresentation;
            string input=Console.ReadLine();
            double grade;
            double totalAverageGrade = 0;
            double numberOfPresentations = 0;

            while(input!="Finish")
            {
                nameOfPresentation = input;
                double averageFrade = 0;

                for (int i = 1; i <=membersOfJury; i++)
                {
                    grade = double.Parse(Console.ReadLine());
                    averageFrade += grade;

                }
                averageFrade /= membersOfJury;
                totalAverageGrade += averageFrade;
                Console.WriteLine($"{nameOfPresentation} - {averageFrade:f2}.");
                input= Console.ReadLine();
                numberOfPresentations ++;
            }
            
            if(input=="Finish")
            {
                Console.WriteLine($"Student's final assessment is {totalAverageGrade/numberOfPresentations:f2}.");
            }
        }
    }
}
