using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises
{
    internal class BasicExercise18
    {
        /***************************************************************************************************************

            18. Check Positive and Negative Pair

                Write a C# program to check a pair of integers and return true if one is negative and one is positive.
                Sample Output:
                Input first integer:
                -5
                Input second integer:
                25
                Check if one is negative and one is positive:
                True

        ****************************************************************************************************************/

        public static void Run()
        {
            int int1, int2;

            Console.Write("Input first integer: ");
            int1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input second integer: ");
            int2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Check if one is negative and one is positive:");

            //Approach 1
            if (int1 < 0 && int2 < 0)
            {
                Console.WriteLine("False");

            } else if (int1 > 0 && int2 > 0)
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("True");
            }

            //Approach 2
            Console.WriteLine((int1 < 0 && int2 > 0) || (int1 > 0 && int2 < 0));

            //Approach 3
            Console.WriteLine(int1 * int2 < 0);

        }
    }
}
