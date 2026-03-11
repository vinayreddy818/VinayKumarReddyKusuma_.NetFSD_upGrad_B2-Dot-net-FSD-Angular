using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleWeek4Day3
{
    internal class Simple_Calculator
    {
        static void Main() 
        {
            Console.WriteLine("Enter First Number : ");
            int Num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number: ");
            int Num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Operator('+','-','*','/')");
            char Operator = Convert.ToChar(Console.ReadLine());
            Double Result;
            switch (Operator) 
            {
                case '+':
                    Result=Num1+ Num2;
                    Console.WriteLine($"Result : {Result}");
                    break;
                case '-':
                    Result = Num1 - Num2;
                    Console.WriteLine($"Result : {Result}");
                    break;
                case '*':
                    Result = Num1 * Num2;
                    Console.WriteLine($"Result : {Result}");
                    break;
                case '/':
                    Result = Num1/Num2;
                    Console.WriteLine($"Result : {Result}");
                    break;
                default:
                    Console.WriteLine("Select Valid Operator");
                    break;
            }
                    
        }
    }
}
