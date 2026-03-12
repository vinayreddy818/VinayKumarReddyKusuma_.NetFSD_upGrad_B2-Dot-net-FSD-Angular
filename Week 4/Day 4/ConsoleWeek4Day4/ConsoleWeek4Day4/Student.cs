using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleWeek4Day4
{
    internal class Student
    {
        static void Main()
        {
            Student s = new Student();
            Console.WriteLine("Enter Marks 1 :");
            int marks1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Marks 2 :");
            int marks2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Marks 3 :");
            int marks3 = Convert.ToInt32(Console.ReadLine());
            double averageMarks = s.CalculateAverage(marks1, marks2, marks3);
            char grade;
            if(averageMarks >= 90)
            {
                grade = 'A';
            }
            else if(averageMarks >= 70)
            {
                grade = 'B';
            }
            else if( averageMarks >= 50)
            {
                grade = 'C';
            }
            else
            {
                grade = 'F';
            }
            Console.WriteLine($"Average = {averageMarks},Grade = {grade}");
        }
        public double CalculateAverage (int marks1 , int marks2 , int marks3)
        {
            double average = (marks1 + marks2 + marks3) / 3;
            return average;
        }

    }
}
