using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleWeek4Day3
{
    internal class NumberAnalysis
    {
        static void Main()
        {
            Console.WriteLine("Enter Number :");
            int N = Convert.ToInt32(Console.ReadLine());
            int EvenCount = 0;
            int OddCount = 0;
            int Sum = 0;
            for (int i = 1; i <= N; i++) 
            {
                Sum = Sum + i;
                if(i%2 == 0)
                {
                    EvenCount++;
                }
                else if(i%2 != 0)
                {
                    OddCount++;
                }
            }
            Console.WriteLine($"Even Count : {EvenCount}\nOdd Count : {OddCount}\nSum : {Sum}");
        }
    }
}
