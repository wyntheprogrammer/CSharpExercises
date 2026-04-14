using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises
{
    /**************************************************************************
     
        3. Divide Two Numbers

           Write a C# Sharp program to print the result of dividing two numbers.

    ****************************************************************************/

    internal class BasicExercise03
    {
        public static void Run()
        {
            // Approach 1
            Console.WriteLine("Approach 1: ");
            Console.WriteLine($"The quotient of 8 and 2 is {8 / 2}");

            Console.WriteLine("");

            // Approach 2
            int a = 8;
            int b = 2;
            int quotient = a / b;

            Console.WriteLine("Approach 2: ");
            Console.WriteLine($"The quotient of {a} and {b} is {quotient}.");

        }
    }
}
