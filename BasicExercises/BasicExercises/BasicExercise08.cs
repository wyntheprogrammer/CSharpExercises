using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises
{
    /*******************************************************************************************
     
        8. Multiplication Table

            Write a C# Sharp program that prints the multiplication table of a number as input.
            Test Data:
            Enter the number: 5
            Expected Output:
            5 * 0 = 0
            5 * 1 = 5
            5 * 2 = 10
            5 * 3 = 15
            ....
            5 * 10 = 50

    *********************************************************************************************/
    internal class BasicExercise08
    {
        public static void Run()
        {
            int num;
            
            Console.Write("Enter the number: ");
            num = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{num} * {i} = {num * i}");
            }

        }    
        
    }
}
