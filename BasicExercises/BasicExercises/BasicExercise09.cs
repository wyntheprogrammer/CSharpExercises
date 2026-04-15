using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises
{
    /*******************************************************************************
      
        9. Average of Four Numbers

            Write a C# Sharp program that takes four numbers 
            as input to calculate and print the average.
            Test Data:
            Enter the First number: 10
            Enter the Second number: 15
            Enter the third number: 20
            Enter the four number: 30

            Expected Output:
            The average of 10 , 15 , 20 , 30 is: 18

    ********************************************************************************/

    internal class BasicExercise09
    {
        public static void Run()
        {
            int num1, num2, num3, num4, avg;

            Console.Write("Enter the First number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Third number: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Fourth number: ");
            num4 = Convert.ToInt32(Console.ReadLine());

            avg = (num1 + num2 + num3 + num4) / 4;

            Console.WriteLine($"The average of {num1}, {num2}, {num3}, {num4} is: {avg}");

        }

    }
}
