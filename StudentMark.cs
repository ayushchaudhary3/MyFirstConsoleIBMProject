using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleIBMProject
{
    internal class StudentMark
    {
        string name;
        string subject1, subject2, subject3, subject4, subject5;
        int mark1, mark2, mark3, mark4, mark5;

        public void InputDetails()
        {
            Console.WriteLine("Enter Student Name:");
            name = Console.ReadLine();

            Console.WriteLine("Enter name for Subject 1:");
            subject1 = Console.ReadLine();
            Console.WriteLine("Enter marks for Subject 1:");
            mark1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter name for Subject 2:");
            subject2 = Console.ReadLine();
            Console.WriteLine("Enter marks for Subject 2:");
            mark2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter name for Subject 3:");
            subject3 = Console.ReadLine();
            Console.WriteLine("Enter marks for Subject 3:");
            mark3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter name for Subject 4:");
            subject4 = Console.ReadLine();
            Console.WriteLine("Enter marks for Subject 4:");
            mark4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter name for Subject 5:");
            subject5 = Console.ReadLine();
            Console.WriteLine("Enter marks for Subject 5:");
            mark5 = Convert.ToInt32(Console.ReadLine());
        }

        public int TotalMarks()
        {
            return mark1 + mark2 + mark3 + mark4 + mark5;
        }

        public double AverageMarks()
        {
            return TotalMarks() / 5.0;
        }

        public void PrintResult()
        {
            Console.WriteLine($"Total Marks for {name}: {TotalMarks()}");
            Console.WriteLine($"Average Marks for {name}: {AverageMarks()}");
        }
    }
}
