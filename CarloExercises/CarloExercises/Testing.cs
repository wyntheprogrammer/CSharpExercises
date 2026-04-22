using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarloExercises
{
    internal class Testing
    {
        public static void Run()
        {
            Console.Write("Input equation: ");
            string input = Console.ReadLine();

            string[] array = new string[input.Length + 1];


            // counter 
            int count = 0;

            for (int ct = 0; ct < input.Length; ct++)
            {
                string numberInput = Convert.ToString(input[ct]);

                long num = 0;
                bool cnv = long.TryParse(numberInput, out num);

                if (cnv == false)
                {
                    count = count + 2;
                }

            }

            count = count + 1;






            //string[] temp = new string[10];

            var temp = new System.Text.StringBuilder();





            //Putting user input to array
            for (int i = 0; i < input.Length; i++)
            {
                //array.SetValue($"{input[i]}", i);


                // null counter

                int countagain = 1;

                int nullCount = 0;

                for (int nct = 0; nct < countagain; nct++)
                {
                    string nullNumberInput = Convert.ToString(input[nct]);

                    long nullNum = 0;
                    bool nullcnv = long.TryParse(nullNumberInput, out nullNum);

                    if (array[nct] == null)
                    {
                        nullCount = nullCount + nct;
                    }
                    else
                    {
                        countagain = countagain + 1;
                    }


                }


                string numInput = Convert.ToString(input[i]);

                long number = 0;
                bool convert = long.TryParse(numInput, out number);


                if (convert == true)
                {
                    temp.Append($"{input[i]}");
                }
                else
                {
                    string result = temp.ToString();

                    array.SetValue($"{result}", nullCount);
                    array.SetValue($"{input[i]}", nullCount + 1);

                    //for (int j = 0; j < nullCount; j++)
                    //{

                    //    if (array[j] == null)
                    //    {

                    //        string index = array[j];
                    //        string result = temp.ToString();

                    //        array.SetValue($"{result}", j);
                    //        array.SetValue($"{input[i]}", j + 1);
                    //    }
                    //}

                    temp.Clear();

                }

            }


            for (int k = 0; k < count; k++)
            {

                if (array[k] == null)
                {

                    string index = array[k];
                    string result = temp.ToString();

                    array.SetValue($"{result}", k);
                }
            }
            temp.Clear();


            string[] operations = { "*", "/", "+", "-" };

            for (int a = 0; a < 4; a++)
            {
                for (int b = 0; b < array.Length; b++)
                {
                    if (operations[a] == array[b])
                    {
                        if (array[b] == "*")
                        {
                            for (int equation = 0; equation < array.Length; equation++)
                            {

                                if (array[equation] == "*")
                                {
                                    //Console.WriteLine(input.Substring(0, i));
                                    //Console.WriteLine(input[i]);
                                    //Console.WriteLine(input.Substring(i + 1));

                                    int num1 = Convert.ToInt32(array[equation - 1]);
                                    int num2 = Convert.ToInt32(array[equation + 1]);
                                    int product = num1 * num2;
                                    array.SetValue($"{product}", equation - 1);

                                    array = array.Where(num => num != array[equation]).ToArray();
                                    array = array.Where((value, num) => num != equation).ToArray();


                                    for (int division = 0; division < array.Length; division++)
                                    {
                                        if (array[division] == "/")
                                        {
                                            int d1 = Convert.ToInt32(array[division - 1]);
                                            int d2 = Convert.ToInt32(array[division + 1]);
                                            int quotient = d1 / d2;
                                            array.SetValue($"{quotient}", division - 1);

                                            array = array.Where(num => num != array[division]).ToArray();
                                            array = array.Where((value, num) => num != division).ToArray();

                                            for (int addition = 0; addition < array.Length; addition++)
                                            {
                                                if (array[addition] == "+")
                                                {
                                                    int a1 = Convert.ToInt32(array[addition - 1]);
                                                    int a2 = Convert.ToInt32(array[addition + 1]);
                                                    int sum = a1 + a2;
                                                    array.SetValue($"{sum}", addition - 1);

                                                    array = array.Where(num => num != array[addition]).ToArray();
                                                    array = array.Where((value, num) => num != addition).ToArray();

                                                    for (int subtraction = 0; subtraction < array.Length; subtraction++)
                                                    {
                                                        if (array[subtraction] == "-")
                                                        {
                                                            int s1 = Convert.ToInt32(array[subtraction - 1]);
                                                            int s2 = Convert.ToInt32(array[subtraction + 1]);
                                                            int difference = s1 - s2;

                                                            array.SetValue($"{difference}", subtraction - 1);

                                                            array = array.Where(num => num != array[subtraction]).ToArray();
                                                            array = array.Where((value, num) => num != subtraction).ToArray();

                                                        }
                                                    }

                                                }
                                            }
                                        }
                                    }

                                }

                            }
                        }

                        else if (array[b] == "/")
                        {
                            for (int equation = 0; equation < array.Length; equation++)
                            {

                                if (array[equation] == "/")
                                {
                                    int d1 = Convert.ToInt32(array[equation - 1]);
                                    int d2 = Convert.ToInt32(array[equation + 1]);
                                    int quotient = d1 / d2;
                                    array.SetValue($"{quotient}", equation - 1);

                                    array = array.Where(num => num != array[equation]).ToArray();
                                    array = array.Where((value, num) => num != equation).ToArray();

                                    for (int addition = 0; addition < array.Length; addition++)
                                    {
                                        if (array[addition] == "+")
                                        {
                                            int a1 = Convert.ToInt32(array[addition - 1]);
                                            int a2 = Convert.ToInt32(array[addition + 1]);
                                            int sum = a1 + a2;
                                            array.SetValue($"{sum}", addition - 1);

                                            array = array.Where(num => num != array[addition]).ToArray();
                                            array = array.Where((value, num) => num != addition).ToArray();

                                            for (int subtraction = 0; subtraction < array.Length; subtraction++)
                                            {
                                                if (array[subtraction] == "-")
                                                {
                                                    int s1 = Convert.ToInt32(array[subtraction - 1]);
                                                    int s2 = Convert.ToInt32(array[subtraction + 1]);
                                                    int difference = s1 - s2;

                                                    array.SetValue($"{difference}", subtraction - 1);

                                                    array = array.Where(num => num != array[subtraction]).ToArray();
                                                    array = array.Where((value, num) => num != subtraction).ToArray();

                                                }
                                            }

                                        }
                                    }

                                }

                            }
                        }

                        else if (array[b] == "+")
                        {
                            for (int equation = 0; equation < array.Length; equation++)
                            {

                                if (array[equation] == "+")
                                {
                                    int a1 = Convert.ToInt32(array[equation - 1]);
                                    int a2 = Convert.ToInt32(array[equation + 1]);
                                    int sum = a1 + a2;
                                    array.SetValue($"{sum}", equation - 1);

                                    array = array.Where(num => num != array[equation]).ToArray();
                                    array = array.Where((value, num) => num != equation).ToArray();

                                    for (int subtraction = 0; subtraction < array.Length; subtraction++)
                                    {
                                        if (array[subtraction] == "-")
                                        {
                                            int s1 = Convert.ToInt32(array[subtraction - 1]);
                                            int s2 = Convert.ToInt32(array[subtraction + 1]);
                                            int difference = s1 - s2;

                                            array.SetValue($"{difference}", subtraction - 1);

                                            array = array.Where(num => num != array[subtraction]).ToArray();
                                            array = array.Where((value, num) => num != subtraction).ToArray();

                                        }
                                    }

                                }

                            }
                        }


                        else if (array[b] == "-")
                        {
                            for (int equation = 0; equation < array.Length; equation++)
                            {

                                if (array[equation] == "-")
                                {
                                    int s1 = Convert.ToInt32(array[equation - 1]);
                                    int s2 = Convert.ToInt32(array[equation + 1]);
                                    int difference = s1 - s2;

                                    array.SetValue($"{difference}", equation - 1);

                                    array = array.Where(num => num != array[equation]).ToArray();
                                    array = array.Where((value, num) => num != equation).ToArray();


                                }

                            }
                        }




                    }
                }
            }






            //Displaying the output
            for (int l = 0; l < array.Length; l++)
            {
                Console.Write(array[l]);
            }




            //for (int equation = 0; equation < array.Length; equation++)
            //{

            //    if (array[equation] == "*")
            //    {
            //        //Console.WriteLine(input.Substring(0, i));
            //        //Console.WriteLine(input[i]);
            //        //Console.WriteLine(input.Substring(i + 1));

            //        int num1 = Convert.ToInt32(array[equation - 1]);
            //        int num2 = Convert.ToInt32(array[equation + 1]);
            //        int product = num1 * num2;
            //        array.SetValue($"{product}", equation - 1);

            //        array = array.Where(num => num != array[equation]).ToArray();
            //        array = array.Where((value, num) => num != equation).ToArray();


            //        for (int division = 0; division < array.Length; division++)
            //        {
            //            if (array[division] == "/")
            //            {
            //                int d1 = Convert.ToInt32(array[division - 1]);
            //                int d2 = Convert.ToInt32(array[division + 1]);
            //                int quotient = d1 / d2;
            //                array.SetValue($"{quotient}", division - 1);

            //                array = array.Where(num => num != array[division]).ToArray();
            //                array = array.Where((value, num) => num != division).ToArray();

            //                for (int addition = 0; addition < array.Length; addition++)
            //                {
            //                    if (array[addition] == "+")
            //                    {
            //                        int a1 = Convert.ToInt32(array[addition - 1]);
            //                        int a2 = Convert.ToInt32(array[addition + 1]);
            //                        int sum = a1 + a2;
            //                        array.SetValue($"{sum}", addition - 1);

            //                        array = array.Where(num => num != array[addition]).ToArray();
            //                        array = array.Where((value, num) => num != addition).ToArray();

            //                        for (int subtraction = 0; subtraction < array.Length; subtraction++)
            //                        {
            //                            if (array[subtraction] == "-")
            //                            {
            //                                int s1 = Convert.ToInt32(array[subtraction - 1]);
            //                                int s2 = Convert.ToInt32(array[subtraction + 1]);
            //                                int difference = s1 - s2;

            //                                array.SetValue($"{difference}", subtraction - 1);

            //                                array = array.Where(num => num != array[subtraction]).ToArray();
            //                                array = array.Where((value, num) => num != subtraction).ToArray();

            //                            }
            //                        }

            //                    }
            //                }
            //            }
            //        }

            //    } 

            //}








        }

    }
}
