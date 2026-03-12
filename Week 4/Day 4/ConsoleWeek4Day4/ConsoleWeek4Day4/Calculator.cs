using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ConsoleWeek4Day4
{
    internal class Calculator
    {
        static void Main()
        {
            Calculator sc = new Calculator();
            Console.WriteLine("Enter 2 values ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int add = sc.Add(a , b);
            int sub = sc.Subtract(a, b);
            Console.WriteLine($"Addition = {add}, Subtraction = {sub}");
        }
        public int Add(int a , int b)
        {
            int sum = a + b;
            return sum;
        }
        public int Subtract(int a, int b) 
        { 
            int sub = a - b;
            return sub; 
        }
    }
}
