using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Application
{
    public class ArrayExercise
    {
        public static void GetOdd(int[] Array)
        {
            // TODO
            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] % 2 != 0)
                {
                    
                    Console.WriteLine(Array[i]);
                }
            }
        }

        public static void GetEven(int[] Array)
        {
            // TODO
            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] % 2 == 0)
                {
                   
                    Console.WriteLine(Array[i]);
                }
            }
        }
        static void Main(string[] args)
        {
            int[] array = { 20,21,22,23,24,25,26,27,28,29,30 };
            Console.WriteLine("Odd Number Is :");
            GetOdd(array);
            Console.WriteLine("Even Number Is :");
            GetEven(array);
            Console.ReadKey();
        }
    }
}
