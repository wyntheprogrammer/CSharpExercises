using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ArrayExercises
{
    /*************************************************************************************************

        2. Write a C# Sharp program to read n values in an array and display them in reverse order.
            Test Data :
            Input the number of elements to store in the array :3
            Input 3 number of elements in the array :
            element - 0 : 2
            element - 1 : 5
            element - 2 : 7
            Expected Output:
            The values store into the array are:
            2 5 7
            The values store into the array in reverse are :
            7 5 2
    
    ***************************************************************************************************/

    internal class ArrayExercise02
    {
        public static void Run()
        {
            Console.Write("Input the number of element to store in the array: ");
            int numArr = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine($"Input {numArr} number of elements in the array :");

            int[] arr = new int[numArr];

            for (int i = 0; i < numArr; i++)
            {
                Console.Write($"element - {i}: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }


            Console.WriteLine("The values store into the array are: ");

            for (int j = 0; j < numArr; j++)
            {
                Console.Write(arr[j] + " ");
            }

            Console.WriteLine("");

            Console.WriteLine("The values store into the array in reverse are: ");

            //My Approach
            for (int k = 0; k < numArr; k++)
            {
                Console.Write(arr[numArr-k-1] + " ");
            }


            //w3resource Approach
            //for (int k = numArr-1; k >= 0; k--)
            //{
            //    Console.Write(arr[k] + " ");
            //}


        }
    }
}
