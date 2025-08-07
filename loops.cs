using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleIBMProject
{
    internal class loops
    {
        public void ForLoop()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"For Loop iteration: {i}");
            }
        }

        public void WhileLoop()
        {
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine($"While Loop iteration: {i}");
                i++;
            }
        }

        public void DoWhileLoop()
        {
            int i = 0;
            do
            {
                Console.WriteLine($"Do-While Loop iteration: {i}");
                i++;
            } while (i < 10);
        }
    }
}
