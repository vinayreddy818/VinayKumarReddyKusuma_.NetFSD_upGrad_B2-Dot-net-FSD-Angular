using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleWeek5Day2
{
    internal class DivisionException
    {
        public static void Main()
        {
            Console.WriteLine("Numerator = ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Denominator = ");
            int den = Convert.ToInt32(Console.ReadLine());
            Divide(num, den);
        }
        public static void Divide(int num, int den)
        {
            double div;
            try
            {
                div = num % den;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Cannot divide by zero");
            }
            finally
            {
                Console.WriteLine("Program Executed Successfully");
            }
        }
    }
}
