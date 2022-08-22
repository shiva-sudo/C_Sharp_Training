using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Application
{
    class List
    {
        //Write A program to print Even integer number between 100 to 170
        static void Main(string[] args)
        {
            List<int> mylist = new List<int>();

            for (int i = 100; i <= 170; i++)
            {  
                if (i % 2 == 0)
                {
                   mylist.Add(i);
                   Console.Write(" "+i);
                }
                
            }
            
            Console.ReadLine();
        }
    }
}
