using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleWeek4Day5
{
    internal class BankAccount
    {
        private double balance = 0;
        public void deposit(double depositAmount)
        {
            balance += depositAmount;
        }
        public void withDraw(double withDrawAmount) 
        {
            if (withDrawAmount > balance)
            {
                Console.WriteLine("Insufficient balance");
            }
            else
            {
                balance -= withDrawAmount;

            }
        }
        public double getBalance() 
        {
            return balance;
        }

    }
}
