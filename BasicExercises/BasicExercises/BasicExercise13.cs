using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises
{
    /************************************************************************
     
        13. Rectangle Pattern with Number

            Write a C# program that takes a number as input and displays a 
            rectangle of 3 columns wide and 5 rows tall using that digit.

            Test Data:
            Enter a number: 5
            Expected Output:
            555
            5 5
            5 5
            5 5
            555

    *************************************************************************/

    internal class BasicExercise13
    {
        public static void Run()
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

       
            Console.WriteLine($"{num}{num}{num}");

            for (int j = 0; j <= 2; j++)
            {
                Console.WriteLine($"{num} {num}");
            }

            Console.WriteLine($"{num}{num}{num}");


        }
    }
}
