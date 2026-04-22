using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Schema;

namespace ArrayExercises
{
    /***********************************************************************

    3. Write a program in C# Sharp to find the sum of all array elements.
        Test Data :
        Input the number of elements to be stored in the array :3
        Input 3 elements in the array :
        element - 0 : 2
        element - 1 : 5
        element - 2 : 8
        Expected Output :
        Sum of all elements stored in the array is : 15

    ************************************************************************/

    internal class ArrayExercise03
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

            int total = 0;

            for (int i =0; i < numArr; i++)
            {
                total += arr[i];
            }

            Console.Write($"Sum of all elements stored in the array is : {total}");
        }

    }
}
