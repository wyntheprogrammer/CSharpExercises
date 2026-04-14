using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises
{
    /******************************************************************
     
        2. Sum of Two Numbers
    
           Write a C# Sharp program to print the sum of two numbers.

    *******************************************************************/

    internal class BasicExercise02
    {
        public static void Run()
        {
            // Approach 1
            Console.WriteLine("Approach 1: ");
            Console.WriteLine($"The sum of 1 and 2 is {1 + 2}");

            Console.WriteLine("");

            // Approach 2
            int a = 1;
            int b = 2;
            int sum = a + b;

            Console.WriteLine("Approach 2: ");
            Console.WriteLine($"The sum of {a} and {b} is {sum}.");

        }
    }
}
