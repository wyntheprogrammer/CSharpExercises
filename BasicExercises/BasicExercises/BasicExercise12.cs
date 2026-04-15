using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises
{
    /***************************************************************************************
     
        12. Repeat Number in Rows

            Write a C# program that takes a number as input and displays it four times 
            in a row (separated by blank spaces), and then four times in the next row, 
            with no separation. You should do it twice: Use the console. Write and use {0}.

            Test Data:
            Enter a digit: 25
            Expected Output:
            25 25 25 25
            25252525
            25 25 25 25
            25252525

    ******************************************************************************************/

    internal class BasicExercise12
    {
        public static void Run()
        {
            Console.Write("Enter a digit: ");
            string digit = Console.ReadLine();

            for (int i = 0; i <= 1; i++)
            {
                Console.WriteLine($"{digit} {digit} {digit}  {digit}");

                Console.WriteLine($"{digit}{digit}{digit}{digit}");
            }
        }

    }
}
