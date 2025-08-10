using System;

namespace MyFirstConsoleIBMProject
{
    // Child Class
    internal class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount() { }

        public SavingsAccount(string accountNumber, string accountHolderName, double balance, double interestRate)
            : base(accountNumber, accountHolderName, balance)
        {
            InterestRate = interestRate;
        }

        public void ApplyInterest()
        {
            double interest = Balance * (InterestRate / 100);
            Balance += interest;
            Console.WriteLine($"Interest of {interest} applied. New balance: {Balance}");
        }
    }
}