using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarloExercises
{
    internal class CarloExercise04
    {
        public static void Run()
        {
            int num1 = 1;
            int num2 = 2;

            Console.Write("Enter a number: ");
            int input = Convert.ToInt32(Console.ReadLine());

            for (int l = 0; l < input + 1; l++)
            {
                Console.Write(l + " ");
            }

            Console.WriteLine();

            for (int i = 1; i <= input; i++)
            {
                Console.Write(i + " ");

                for (int j = 1; j <= input; j++)
                {

                    for (int k = num1; k < num2; k++)
                    {
                        int result = j * k;

                        Console.Write(result);
                        Console.Write(" ");
                    }
                }

                num1 += 1;
                num2 += 1;

                Console.WriteLine();
            }

        }
    }
}
