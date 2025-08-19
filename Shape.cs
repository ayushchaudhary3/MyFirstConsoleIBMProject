using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleIBMProject
{
    internal class Shape <T>
    {
        private T shapeName;
        public Shape()
        {
            shapeName = default(T); // Initialize shapeName to the default value of type T
        }

        public Shape(T name)
        {
            shapeName = name; // Initialize shapeName with the provided name
        }

        public T GetShapeName
        {
            get { return shapeName; } // Return the name of the shape
            set { shapeName = value; } // Set the name of the shape
        }

        public override string ToString()
        {
            return $"Shape Name: {shapeName}"; // Return a string representation of the shape
        }
    }
}
