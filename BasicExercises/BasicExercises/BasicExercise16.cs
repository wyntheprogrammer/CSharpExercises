using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace BasicExercises
{
    /**************************************************************************
        16. Swap First and Last Characters

            Write a C# program to create a new string from a given string 
            where the first and last characters change their positions.
            Test Data:
            w3resource
            Python
            Sample Output:
            e3resourcw
            nythoP
            x
    *****************************************************************************/

    internal class BasicExercise16
    {
       public static void Run()
       {
            string str1, str2, str3;

            str1 = "w3resource";
            str2 = "Python";
            str3 = "x";


            Console.WriteLine(Swap(str1));
            Console.WriteLine(Swap(str2));
            Console.WriteLine(Swap(str3));

        }

        public static string Swap(string str)
        {
            char[] charArray = str.ToCharArray();

            char temp = charArray[0];
            charArray[0] = charArray[charArray.Length - 1];
            charArray[charArray.Length - 1] = temp;

            string swappedString = new string(charArray);

            return swappedString;
        }

    }
}
