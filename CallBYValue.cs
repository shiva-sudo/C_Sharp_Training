using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Application
{
    public class CallBYValue
    {
        public void Show(int val)
        {
            val = val * val;
            Console.WriteLine("Value inside the show function  "+ val);
        }
       
    }
    public class CallByReference
    {
        public void Show( ref int val)
        {
            val = val * val;
            Console.WriteLine("Value inside the show function  " + val);
        }
        //public static void Main(string[] args)
        //{
        //    int val = 50;

        //    // This is the instance of call by value 
        //    //CallBYValue cb = new CallBYValue();    

        //    // This is the instance of call  by  reference 
        //    CallByReference Cfr = new CallByReference(); 
            
        //    Console.WriteLine("Valu before calling the function " + val);
        //    Cfr.Show( ref val);
        //    Console.WriteLine(" Value after the calling function " + val);
        //    Console.ReadLine();
        //}
    }
    
}
