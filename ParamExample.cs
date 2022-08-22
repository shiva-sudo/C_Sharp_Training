using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Application
{

    class ParamExample
    {
        //write a method using params which returns the sum of Given ArrayList
        public static int Add(params int[] Arraylist)
        {
            int total = 0;
            foreach(int i in Arraylist)
            {
                total += i;
            }
            return total;
        }
        public void Result(params object[] array)
        {
            for (int i = 0; i < array.Length; i++)
            //foreach(int obj in array)
            {

                // Display result
                Console.WriteLine(array[i]);
            }
        }
        static void Main(string[] args)
        {
            ParamExample pm = new ParamExample();
            pm.Result("Geeks", "GFG","ProGeek Cup 2.0","G4G", "100");//Object type Params 
            Console.WriteLine("The sum of ArrayList is {0}",Add(1,2,3,4,5,6,7,8,9)); //simple method of Params
            Console.ReadLine();
        }
    }
}
