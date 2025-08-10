using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleIBMProject
{
    internal class EmployeeChild : Person
    {
        public int EmployeeId { get; set; }
        public string? Role {  get; set; } //nullable
        public string? Email { get; set; } 
        public double Salary { get; set; }

        // Constructor
        public EmployeeChild() { }
        public EmployeeChild(int id, int employeeId, string name, string city, int age, string role, string email, double salary)
            : base(id, name, city, age) // Call the base class constructor
        {
            EmployeeId = employeeId;
            Role = role;
            Email = email;
            Salary = salary;
        }
        // Method to display employee details
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"Employee ID: {EmployeeId}" );
            Console.WriteLine($"Role: {Role}" );
            Console.WriteLine($"Email: {Email}" );
            Console.WriteLine($"Salary: {Salary}" );
        }
    }
}
