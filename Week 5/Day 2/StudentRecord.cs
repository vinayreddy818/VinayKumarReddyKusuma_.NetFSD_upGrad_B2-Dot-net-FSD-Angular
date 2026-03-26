using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleWeek5Day2
{
    public record class Student(int RollNo, string Name, string Course, int Marks);
    internal class StudentRecord
    {
        public static void Main()
        {
            List<Student> li = new List<Student>();
            Console.WriteLine("Enter number of students:");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter Roll Number :");
                int RollNum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Name :");
                string Name = Console.ReadLine();
                Console.WriteLine("Enter Course :");
                string Course = Console.ReadLine();
                Console.WriteLine("Enter Marks :");
                int Marks = Convert.ToInt32(Console.ReadLine());
                li.Add(new Student(RollNum, Name, Course, Marks));
            }
            Console.WriteLine("Search Roll Number:");
            int rolNm = Convert.ToInt32(Console.ReadLine());
            foreach(var s in li)
            {
                Console.WriteLine($"Roll No: {s.RollNo} | Name: {s.Name} | Course: {s.Course} | Marks: {s.Marks}");
            }
            var result = li.Find(s => s.RollNo == rolNm);

            if (result != null)
            {
                Console.WriteLine("\nStudent Found:");
                Console.WriteLine($"Roll No: {result.RollNo} | Name: {result.Name} | Course: {result.Course} | Marks: {result.Marks}");
            }
            else
            {
                Console.WriteLine("Student not found!");
            }
        }
    }
}
