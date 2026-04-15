using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises
{
    /*******************************************************************
     
        15. Remove Character by Index

            Write a C# program that removes a specified character from 
            a non-empty string using the index of a character.
            
            Test Data:
            w3resource
            Sample Output:
            wresource
            w3resourc
            3resource

    *********************************************************************/

    internal class BasicExercise15
    {
        public static void Run()
        {
            //My Approach
            string text = "w3resource";

            string trim1 = text.Remove(1, 1);
            string trim1B = text.Replace("3", "");

            string trim3 = text.Substring(0, text.Length - 1);
            string trim2 = text.Substring(1);

            Console.WriteLine(trim1);
            Console.WriteLine(trim1B);
            Console.WriteLine(trim2);
            Console.WriteLine(trim3);


            Console.WriteLine("\nOther Approach: \n");
            Trim();

        }


        //Other Approach
        public static void Trim()
        {
            Console.WriteLine(remove_char("w3resource", 1));
            Console.WriteLine(remove_char("w3resource", 9));
            Console.WriteLine(remove_char("w3resource", 0));
        }


        public static string remove_char(string str, int n)
        {
            return str.Remove(n,1);
        }
    }
}
