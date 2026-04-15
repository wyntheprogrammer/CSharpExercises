using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises
{
    /***************************************************************************************
     
        17. Add First Character to Front and Back

            Write a C# program to create a string from a given string (length 1 or more) 
            with the first character added at the front and back.
            Sample Output:
            Input a string : The quick brown fox jumps over the lazy dog.
            TThe quick brown fox jumps over the lazy dog.T

    *****************************************************************************************/

    internal class BasicExercise17
    {
        public static void Run()
        {
            string str;

            Console.Write("Input a string : ");
            str = Console.ReadLine();

            //Approach 1
            char[] chars = str.ToCharArray();

            char temp = chars[0];
            
            Console.Write( temp + str + temp);


            //Approach 2
            Console.Write(str[0] + str + str[0]);

        }
    }
}
