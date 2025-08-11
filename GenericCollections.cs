using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleIBMProject
{
    internal class GenericCollections
    {
        public List <int> numbers = new List<int>(); //generic list to hold integers
        public List<string> names = new List<string>(); //generic list to hold strings
        public List<Person> persons = new List<Person>(); //generic list to hold Person objects

        public void AddNumbers(int number)
        {
            numbers.Add(number); // Add a number to the list
        }
        public void AddName(string name)
        {
            names.Add(name); // Add a name to the list
        }
        public void RemoveName(string name)
        {
            names.Remove(name); // Remove a name from the list
        }
        public void AddPerson(Person person)
        {
            persons.Add(person); // Add a Person object to the list
        }
        public void DisplayNumbers()
        {
            Console.WriteLine("Numbers in the list:");
            foreach (var number in numbers)
            {
                Console.Write(number + " "); // Display each number
            }
        }
        public void RemoveNumber(int number)
        {
            numbers.Remove(number); // Remove a number from the list
        }
        public void ClearNumbers()
        {
            numbers.Clear(); // Clear all numbers from the list
        }
        public void DisplayNames()
        {
            Console.WriteLine("Names in the list:");
            foreach (var name in names)
            {
                Console.Write(name + " "); // Display each name
            }
        }
        public void DisplayPersons()
        {
            Console.WriteLine("Persons in the list:");
            foreach (var person in persons)
            {
                Console.WriteLine($"Name: {person.Name}, Age: {person.Age}"); // Display each person's details
            }
        }
    }
}
