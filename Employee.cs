using System;

namespace MyFirstConsoleIBMProject
{
    internal class Employee
    {
        string name;
        string role;
        string department;
        double basicSalary;
        double pf;
        double gratuity;
        double tax;
        double netSalary;

        public void InputDetails()
        {
            Console.Write("Enter employee name: ");
            name = Console.ReadLine();

            Console.Write("Enter employee role: ");
            role = Console.ReadLine();

            Console.Write("Enter employee department: ");
            department = Console.ReadLine();

            Console.Write("Enter basic salary: ");
            basicSalary = Convert.ToDouble(Console.ReadLine());
        }

        public void CalculateSalary()
        {
            pf = basicSalary * 12 / 100;
            gratuity = basicSalary * 5 / 100;
            tax = basicSalary * 10 / 100;
            netSalary = basicSalary + pf + gratuity - tax;
        }

        public void PrintDetails()
        {
            Console.WriteLine("\n--- Employee Details ---");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Role: {role}");
            Console.WriteLine($"Department: {department}");
            Console.WriteLine($"Basic Salary: {basicSalary}");
            Console.WriteLine($"PF: {pf}");
            Console.WriteLine($"Gratuity: {gratuity}");
            Console.WriteLine($"Tax: {tax}");
            Console.WriteLine($"Net Salary: {netSalary}");
        }
    }
}