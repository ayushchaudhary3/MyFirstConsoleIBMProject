using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleIBMProject
{
    internal class Person
    {
        //auto-implemented properties for Person class
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public int Age { get; set; }

        //Constructor to initialize Person object
        public Person() { }
        public Person(int id, string name, string city, int age)
        {
            Id = id;
            Name = name;
            City = city;
            Age = age;
        }
        //Method to set person details
        public void DisplayPersonDetails()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"City: {City}");
            Console.WriteLine($"Age: {Age}");
        }
        //Method to display person details
        public string GetPersonInfo()
        {
            return $"ID: {Id}, Name: {Name}, City: {City}, Age: {Age}";
        }
        //Method to update person details
        public void UpdatePersonDetails(string name, string city, int age)
        {
            Name = name;
            City = city;
            Age = age;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, City: {City}, Age: {Age}";
        }
    }
}
