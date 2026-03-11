using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleWeek4Day3
{
    internal class StudentGradeEvaluator
    {
        static void Main()
        {
            Console.WriteLine("Enter Name");
            string? name = Console.ReadLine();
            Console.WriteLine("Enter Marks");
            byte marks = Convert.ToByte(Console.ReadLine());
            if (marks >= 0 && marks <= 100)
            {
                if (marks >= 90 && marks <= 100)
                {
                    Console.WriteLine($"Student : {name}");
                    Console.WriteLine($"Grade : A");
                }
                else if (marks >= 80 & marks < 90)
                {
                    Console.WriteLine($"Student : {name}");
                    Console.WriteLine($"Grade : B");
                }
                else if (marks >= 70 & marks < 80)
                {
                    Console.WriteLine($"Student : {name}");
                    Console.WriteLine($"Grade : C");
                }
                else if (marks >= 60 & marks < 70)
                {
                    Console.WriteLine($"Student : {name}");
                    Console.WriteLine($"Grade : D");
                }
                else
                {
                    Console.WriteLine($"Student : {name}");
                    Console.WriteLine($"Grade : Fail");
                }
            }
            else
            {
                Console.WriteLine("Enter Valid Marks Between 0 to 100");
            }
        }
    }
}
