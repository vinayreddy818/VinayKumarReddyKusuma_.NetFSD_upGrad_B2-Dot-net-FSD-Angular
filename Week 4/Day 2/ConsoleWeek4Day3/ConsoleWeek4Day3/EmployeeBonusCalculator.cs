using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleWeek4Day3
{
    internal class EmployeeBonusCalculator
    {
        static void Main()
        {
            Console.WriteLine("Enter Name :");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter Salary :");
            double Salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Experience :");
            double Experience = Convert.ToDouble(Console.ReadLine());
            double Bonus;
            double Finalsalary;
            if (Experience > 5)
            {
                Bonus = Salary * 0.15;
                Finalsalary = Salary + Bonus;
            }
            else if (Experience >= 2 && Experience <= 5)
            {
                Bonus = Salary * 0.10;
                Finalsalary = Salary + Bonus;
            }
            else 
            {
                Bonus = Salary * 0.05;
                Finalsalary = Salary + Bonus;
            }
            Console.WriteLine($" Employee : {Name} \n Bonus : {Bonus} \n Final Salary : {Finalsalary}");
        }
    }
}
