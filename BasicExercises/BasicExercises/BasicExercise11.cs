using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace BasicExercises
{
    /********************************************************************
     
        11. Print Age Message

        Write a C# Sharp program that takes an age (for example 20) 
        as input and prints something like "You look older than 20".
        Test Data:
        Enter your age - 25
        Expected Output:
        You look older than 25

    **********************************************************************/

    internal class BasicExercise11
    {
        public static void Run()
        {
            Console.Write("Enter your age - ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"You look older than {age}");
        }

    }
}
