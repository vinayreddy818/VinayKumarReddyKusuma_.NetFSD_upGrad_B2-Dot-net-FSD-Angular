using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleWeek4Day5
{
    internal class BankAccountEncapsulation
    {
        static void Main()
        {
            BankAccount b = new BankAccount();
            Console.WriteLine("Enter Deposit Amount");
            double depositAmount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Withdraw Amount");
            double withDrawAmount = Convert.ToDouble(Console.ReadLine());
            b.deposit(depositAmount);
            b.withDraw(withDrawAmount);
            Console.WriteLine($"Current Balance : {b.getBalance()}");

        }
    }
}