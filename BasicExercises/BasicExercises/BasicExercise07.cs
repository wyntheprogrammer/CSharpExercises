using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises
{
    /****************************************************************************************
     
        7. Arithmetic Operations

            Write a C# Sharp program to print on screen the output of adding, 
            subtracting, multiplying and dividing two numbers entered by the user.
            Test Data:
            Input the first number: 25
            Input the second number: 4
            Expected Output:
            25 + 4 = 29
            25 - 4 = 21
            25 x 4 = 100
            25 / 4 = 6
            25 mod 4 = 1

    ********************************************************************************************/

    internal class BasicExercise07
    {
        public static void Run()
        {
            int firstNum, secondNum, sum, difference, product, quotient, mod;

            Console.Write("Input the first number: ");
            firstNum = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the second number: ");
            secondNum = Convert.ToInt32(Console.ReadLine());

            sum =firstNum + secondNum;
            difference = firstNum - secondNum;
            product = firstNum * secondNum;
            quotient = firstNum / secondNum;
            mod = firstNum % secondNum;

            Console.WriteLine("Output:");
            Console.WriteLine($"{firstNum} + {secondNum} = {sum}");
            Console.WriteLine($"{firstNum} - {secondNum} = {difference}");
            Console.WriteLine($"{firstNum} x {secondNum} = {product}");
            Console.WriteLine($"{firstNum} / {secondNum} = {quotient}");
            Console.WriteLine($"{firstNum} mod {secondNum} = {mod}");

        }
    }
}
