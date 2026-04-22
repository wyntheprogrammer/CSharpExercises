using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BasicExercises
{
    internal class BasicExercise19
    {
        /**********************************************************************
         
            19. Sum or Triple Sum of Integers

                Write a C# program to compute the sum of two given integers. 
                If two values are the same, return the triple of their sum.

        **********************************************************************/
        public static void Run()
        {
            int num1, num2, total;

            Console.Write("Enter first number: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            num2 = int.Parse(Console.ReadLine());

            total = (num1 == num2) ? total = (num1 + num2) * 3 : total = num1 + num2;

            Console.WriteLine("The total is: " + total);
        }
    }
}
