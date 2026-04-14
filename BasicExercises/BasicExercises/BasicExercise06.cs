using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace BasicExercises
{
    /*******************************************************************************************************************
      
        6. Multiply Three Numbers

            Write a C# Sharp program to print the output of the multiplication of three numbers entered by the user.
            Test Data:
            Input the first number to multiply: 2
            Input the second number to multiply: 3
            Input the third number to multiply: 6
            Expected Output:
            2 x 3 x 6 = 36

    ********************************************************************************************************************/

    internal class BasicExercise06
    {
        public static void Run()
        {
            int firstNum, secondNum, thirdNum, total;

            Console.Write("Input the first number to multiply: ");
            firstNum = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the second number to multiply: ");
            secondNum = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the third number to multiply: ");
            thirdNum = Convert.ToInt32(Console.ReadLine());

            total = firstNum * secondNum * thirdNum;

            Console.WriteLine("Output: \n {0} x {1} x {2} = {3}", firstNum, secondNum, thirdNum, total);
        }
    }
}
