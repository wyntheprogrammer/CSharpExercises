using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace BasicExercises
{
    /*********************************************************************************
     
        10. Specified Formula with Three Numbers

        Write a C# Sharp program that takes three numbers 
        (x,y,z) as input and outputs (x+y).z and x.y + y.z.
        Test Data:
        Enter first number - 5
        Enter second number - 6
        Enter third number - 7

        Expected Output:
        Result of specified numbers 5, 6 and 7, (x+y).z is 77 and x.y + y.z is 72

    **********************************************************************************/

    internal class BasicExercise10
    {
        public static void Run()
        {
            int x, y, z, equation1, equation2 ;

            Console.Write("Enter first number - ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number - ");
            y = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter third number - ");
            z = Convert.ToInt32(Console.ReadLine());

            equation1 = (x + y) * z;
            equation2 = x * y + y * z;

            Console.WriteLine($"Result of specified numbers {x}, {y}, {z}, (x+y).z is {equation1} and x.y + y.z is {equation2} ");




        }
    }
}
