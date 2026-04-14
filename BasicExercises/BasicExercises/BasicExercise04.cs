using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace BasicExercises
{
    /***********************************************************************************

        4. Specified Operations Results

           Write a C# Sharp program to print the results of the specified operations.
           Test data:

           -1 + 4 * 6
           ( 35+ 5 ) % 7
           14 + -4 * 6 / 11
           2 + 15 / 6 * 1 - 7 % 2

            Expected Output:
            23
            5
            12
3

    *************************************************************************************/

    internal class BasicExercise04
    {
        public static void Run()
        {
            int equation1 = -1 + 4 * 6;
            int equation2 = (35 + 5) % 7;
            int equation3 = 14 + -4 * 6 / 11;
            int equation4 = 2 + 15 / 6 * 1 - 7 % 2;


            Console.WriteLine($"Result 1: {equation1}");
            Console.WriteLine($"Result 2: {equation2}");
            Console.WriteLine($"Result 3: {equation3}");
            Console.WriteLine($"Result 4: {equation4}");


        }
    }
}
