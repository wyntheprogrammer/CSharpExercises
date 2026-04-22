using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarloExercises
{
    internal class CarloExercise01
    {
        public static void Run()
        {
            int[] integers = new int[] { 1, 2, 3, 4 };
            int even = 0;

            foreach (var num in integers)
            {
                if (num % 2 == 0)
                {
                    even += num;

                }

            }

            Console.WriteLine(even);
        }
    }
}
