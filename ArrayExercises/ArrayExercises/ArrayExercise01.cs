using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExercises
{
    /*********************************************************************************

           1. Write a C# Sharp program that stores elements in an array and prints them.
               Test Data:
               Input 10 elements in the array:
               element - 0 : 1
               element - 1 : 1
               element - 2 : 2
               .......
               Expected Output :
               Elements in array are: 1 1 2 3 4 5 6 7 8 9

       ***********************************************************************************/

    internal class ArrayExercise01
    {
        public static void Run()
        {
            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"element - {i}: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
             
            }

            Console.Write("\nElements in array are: ");

            for (int j = 0;j < array.Length;j++)
            {
                Console.Write(array[j] + " ");
            }




        }

    }
}
