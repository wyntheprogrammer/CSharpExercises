using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarloExercises
{
    internal class CarloExercise02
    {
        public static void Run()
        {
            int[] integers = { 1, 2, 3, 4, 5 };



            Console.Write("Enter number of shuffles: ");
            int shuffleCount = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Original Array: ");
            for (int a = 0; a < integers.Length; a++)
            {
                Console.Write(integers[a] + " ");
            }

            Console.WriteLine("");

            for (int i = 0; i < shuffleCount; i++)
            {
                Console.WriteLine("");

                for (int j = 0; j < integers.Length; j++)
                {
                    //Random rand = new Random();
                    //int randomIndex = rand.Next(integers.Length);
                    int randomIndex = 0;

                    int temp = integers[j];
                    integers[j] = integers[randomIndex];
                    integers[randomIndex] = temp;

                }

                for (int k = 0; k < integers.Length; k++)
                {
                    Console.Write(integers[k] + " ");
                }


                Console.WriteLine();
            }
        }
    }
}
