using System;

namespace MyFirstConsoleIBMProject
{
    // Grandchild Class
    internal class SalaryAccount : SavingsAccount
    {
        public string EmployerName { get; set; }

        public SalaryAccount() { }

        public SalaryAccount(string accountNumber, string accountHolderName, double balance, double interestRate, string employerName)
            : base(accountNumber, accountHolderName, balance, interestRate)
        {
            EmployerName = employerName;
        }

        // Override Withdraw: No minimum balance restriction
        public override void Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"[SalaryAccount] Withdrew {amount}. New balance: {Balance}");
            }
            else
            {
                Console.WriteLine("[SalaryAccount] Insufficient balance or invalid amount.");
            }
        }
    }
}