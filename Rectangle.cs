using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleIBMproject
{
    internal class Rectangle
    {
        public double Length { get; set; }
        public double Breadth { get; set; }

        public Rectangle() { }                              // Default Constructor

        public Rectangle(double length, double breadth)
        {
            Length = length;                                // Initialize Length & Breadth
            Breadth = breadth;
        }

        public double GetArea()
        {
            return Length * Breadth;
        }

        public double GetPerimeter()
        {
            return 2 * (Length + Breadth);
        }

        public override string ToString()                   // Called automatically when you print a Rectangle object
        {
            return $"Rectangle [Length: {Length}, Breadth: {Breadth}]";
        }
    }
}