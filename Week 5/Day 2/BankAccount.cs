using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleWeek5Day2
{
    public class InsufficientBalanceException : Exception
    {
        public InsufficientBalanceException(string message) : base(message)
        {
        }
    }

    internal class BankAccount
    {
        private double balance;

        // Constructor
        public BankAccount(double initialBalance)
        {
            balance = initialBalance;
        }

        // Withdraw Method
        public void Withdraw(double amount)
        {
            if (amount > balance)
            {
                // Throw custom exception
                throw new InsufficientBalanceException("Withdrawal amount exceeds available balance");
            }
            else
            {
                balance -= amount;
                Console.WriteLine("Withdrawal successful!");
                Console.WriteLine("Remaining Balance: " + balance);
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Console.Write("Enter Balance: ");
            double balance = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Withdrawal Amount: ");
            double withdrawAmount = Convert.ToDouble(Console.ReadLine());

            BankAccount account = new BankAccount(balance);

            try
            {
                account.Withdraw(withdrawAmount);
            }
            catch (InsufficientBalanceException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Transaction completed.");
            }
        }
    }
}
