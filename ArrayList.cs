using System;
using System.Collections;// Need to add this Name space for Arraylist
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Application
{
    class ArrayListC
    {
        static void Main(string[] args)
        {
            // Declaring the aarray list without undefined amount 
            ArrayList Myaaray = new ArrayList();

            // Declaring the array list with defined Amount 
            ArrayList Myarray2 = new ArrayList(100);

            Myaaray.Add(23);
            Myaaray.Add(34);
            Myaaray.Add(78.88);
            Myaaray.Add("Hello");
            Myaaray.Add(23);

            Console.WriteLine("Count of Element {0}", Myaaray.Count);
            //Delete element at specific Position 
            Myaaray.Remove(23);
            Console.WriteLine("Count of Element {0}", Myaaray.Count);
            //Delete element at specific index
            Myaaray.RemoveAt(0);
            Console.WriteLine("Count of Element {0}",Myaaray.Count);
            Console.ReadLine();
            

        }
    }
}
