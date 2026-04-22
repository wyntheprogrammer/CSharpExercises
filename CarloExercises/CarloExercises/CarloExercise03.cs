using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarloExercises
{
    internal class CarloExercise03
    {
        public static void Run()
        {
            //Where array will be stored
            int[] array = new int[10];

            //List of number to be compared with user input to get the position
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Input a number: ");
                int input = Convert.ToInt32(Console.ReadLine());

                //Condition for not allowing greater than 10
                if (input > 10)
                {
                    while (true)
                    {
                        Console.Write("Please input number not greater than 10 \n");
                        i--;
                        break;
                    }
                }

                else
                {

                    //Condition if already entered number
                    if (input == array[i])
                    {
                        while (true)
                        {
                            Console.WriteLine("You have already entered that number.");
                            i--;
                            break;
                        }
                    }
                    else
                    {
                        //Storing array
                        for (int l = 0; l < array.Length; l++)
                        {
                            //Setting input index
                            if (input == numbers[l])
                            {
                                array.SetValue(input, l);
                            }
                        }
                    }




                    //Displaying first 1-5
                    for (int j = 0; j < 5; j++)
                    {
                        Console.Write(array[j]);
                    }

                    //Displaying 6-10
                    Console.WriteLine();

                    for (int k = 5; k < array.Length; k++)
                    {
                        Console.Write(array[k]);
                    }

                    Console.WriteLine();

                }
            }
        }

    }
}
