using System;

namespace Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfNoGoodGrades=int.Parse(Console.ReadLine());
            string nameTask=Console.ReadLine();
            int noGoodGrades = 0;
            int sumGrades = 0;
            int numberOfProblems = 0;
            string lastProblem = string.Empty;


            while (nameTask!="Enough")
            {
                int grades=int.Parse(Console.ReadLine());
                if (grades<=4)
                {
                    noGoodGrades++;
                }
                if (noGoodGrades==numberOfNoGoodGrades)
                {
                     break;
                }
                sumGrades += grades;
                numberOfProblems++;
                nameTask = Console.ReadLine();
                
                if (nameTask!="Enough")
                {
                    lastProblem =nameTask;
                }

            }
            if (noGoodGrades == numberOfNoGoodGrades)
            {
                Console.WriteLine($"You need a break, {noGoodGrades} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {(double)sumGrades / numberOfProblems:f2}");
                Console.WriteLine($"Number of problems: {numberOfProblems}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
        }
    }
}
