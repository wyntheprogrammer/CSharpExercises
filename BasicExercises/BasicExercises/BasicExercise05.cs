using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace BasicExercises
{
    /*********************************************************
     
        5. Swap Two Numbers

            Write a C# Sharp program to swap two numbers.
            Test Data:
            Input the First Number : 5
            Input the Second Number : 6
            Expected Output:
            After Swapping :
            First Number : 6
            Second Number : 5

    ***********************************************************/

    internal class BasicExercise05
    {
        public static void Run()
        {
            int firstNum, secondNum, temp;

            Console.Write("Input the First Number: ");
            firstNum = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the Second Number: ");
            secondNum = Convert.ToInt32(Console.ReadLine());

            temp = firstNum;
            firstNum = secondNum;
            secondNum = temp;

            Console.WriteLine($"First Number is {firstNum}.");
            Console.WriteLine($"Second Number is {secondNum}.");
        }
    }
}
