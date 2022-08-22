using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Application
{
    class Array
    {
        public class ArrayValue
        {
            public void Print()
            {
                //int[] Values = new int[5] { 2, 3, 4, 5, 6 };   //its define  Size of Array 
                //for each
                //Console.WriteLine(Values[3]); // This Line will print  Only that index Values 

                //******************Single Dimentional  Array**************

                int[] Values = { 4, 5, 6, 1, 2, 3, -2, -1, 0 };
                string[] WeeksDay = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursaday", "Friday", "Saturday" };
                
                
                foreach (string i in WeeksDay)
                {
                   Console.WriteLine("{0} ", i);

                }
                foreach (int i in Values)
                {
                    Console.WriteLine("{0} ", i);
                }

                //******************MultiDimensional Array**************


                int[,] array = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };   // OK
                //array5 = {{1,2}, {3,4}, {5,6}, {7,8}};   // Error

                //***************** Uaing Foreach Loop *******************

                foreach(int i in array)
                {
                    Console.WriteLine("{0}",i);
                }

                //***************** Uaing For Loop *******************

                for (int i=0; i < array.GetLength(0); i++)
                {
                    for(int j=0; j < array.GetLength(1); j++)
                    {
                        Console.Write("{0}", array[i,  j]);
                    }
                    Console.WriteLine();
                }

                //******************Jagged  Array**************

            }
        }
        //static void Main(string[] args)
        //{
        //    ArrayValue v1 = new ArrayValue();
        //    v1.Print();
        //    Console.ReadKey();
        //}

        
    }
}
