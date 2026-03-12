using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleWeek4Day4
{
    internal class RecursivePowerCalculator
    {
        static void Main()
         {
            RecursivePowerCalculator Rp = new RecursivePowerCalculator();
            Console.WriteLine("Enter base number:");
            int baseNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter exponent:");
            int exp = Convert.ToInt32(Console.ReadLine());
            int result = Rp.CalculatePower(baseNum, exp);

            Console.WriteLine("Power Result: " + result);
        }
       public int CalculatePower(int baseNum, int exp)
        {
            if (exp == 0)
                return 1;

            return baseNum * CalculatePower(baseNum, exp - 1);
        }
    }

}
