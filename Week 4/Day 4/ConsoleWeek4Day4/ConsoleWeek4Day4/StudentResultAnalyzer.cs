using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleWeek4Day4
{
    internal class StudentResultAnalyzer
    {
        static void Main()
        {
            StudentResultAnalyzer s = new StudentResultAnalyzer();
            Console.WriteLine("Enter Marks 1 :");
            int marks1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Marks 2 :");
            int marks2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Marks 3 :");
            int marks3 = Convert.ToInt32(Console.ReadLine());
            int totalMarks;
            string resultStatus;
            double averageMarks;
            if ((marks1 >= 0 && marks1 <= 100) && (marks2 >= 0 && marks2 <= 100) && (marks3 >= 0 && marks3 <= 100))
            {
                s.CalculateResult(marks1, marks2, marks3, out totalMarks, out averageMarks);
                if(averageMarks >= 40)
                {
                    resultStatus = "Pass";
                }
                else
                {
                    resultStatus = "Fail";
                }
                Console.WriteLine($"Total Marks : {totalMarks}\nAverage Marks : {averageMarks}\nResult Status : {resultStatus}");
            }
            else
            {
                Console.WriteLine("Please Enter Valid Marks Between 0 to 100");
            }

        }
        public void CalculateResult(int marks1, int marks2, int marks3, out int totalMarks, out double averageMarks)
        {
            totalMarks = marks1 + marks2 + marks3;
            averageMarks = totalMarks / 3;
        }
    }
}
