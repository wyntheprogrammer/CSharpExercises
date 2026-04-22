using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ArrayExercises
{
    /*************************************************************************************
      
        4. Write a C# Sharp program to copy the elements of one array into another array.
            Test Data :
            Input the number of elements to be stored in the array :3
            Input 3 elements in the array :
            element - 0 : 15
            element - 1 : 10
            element - 2 : 12
            Expected Output:
            The elements stored in the first array are :
            15 10 12
            The elements copied into the second array are :
            15 10 12

    **************************************************************************************/

    internal class ArrayExercise04
    {
        public static void Run()
        {
            Console.Write("Input the number of elements to be stored in the array :");
            int numArr = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[numArr];

            for (int i = 0; i < numArr; i++)
            {
                Console.Write($"element - {i} : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }


            int[] cpdArr = new int[numArr];

            for (int i = 0; i < numArr; i++)
            {
                cpdArr[i] = arr[i];
            }


            //Display

            Console.WriteLine("The elements stored in the first array are :");

            for (int i = 0; i < numArr; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine("");

            Console.WriteLine("The elements copied into the second array are :");

            for (int i = 0; i < numArr; i++)
            {
                Console.Write(cpdArr[i] + " ");
            }
        }
    }
}
