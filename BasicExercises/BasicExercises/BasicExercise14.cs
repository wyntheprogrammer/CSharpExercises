using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace BasicExercises
{
    /**********************************************************************************
      
        14. Celsius to Kelvin and Fahrenheit

            Write a C# program to convert Celsius degrees to Kelvin and Fahrenheit.
            Test Data:
            Enter the amount of celsius: 30
            Expected Output:
            Kelvin = 303
            Fahrenheit = 86

    ************************************************************************************/

    internal class BasicExercise14
    {
        public static void Run()
        {
            double celsius, kelvin, fahrenheit;

            Console.Write("Enter amount of celsius: ");
            celsius = Convert.ToInt32(Console.ReadLine());

            kelvin = celsius + 273;
            fahrenheit = (celsius * 1.8) + 32;

            Console.WriteLine($"Kelvin = {kelvin}");
            Console.WriteLine($"Fahrenheit = {fahrenheit}");



        }
    }
}
