using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace ConsoleWeek5Day1
{
    internal class StudentScoreAnalyzer
    {
        public static void Main() 
        {
            List<int> Marks = new List<int>();
            Console.WriteLine("Enter Number of Students");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Student Marks");
            for (int i=0;i<n;i++)
            {
                Marks.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine("Enter Threshold");
            int Threshold = Convert.ToInt32(Console.ReadLine());
            int MarksSum = Marks.Sum();
            double AverageMarks=Marks.Average();
            var marks1 = Marks.Where(m => m > Threshold);
            int Highest = Marks.Max();

            Console.WriteLine("Total Marks: " + MarksSum);
            Console.WriteLine("Average Marks: " + AverageMarks);
            Console.WriteLine("Students above 80: " + marks1.Count());
            Console.WriteLine("Highest Score: " + Highest);


        }

    }
}
