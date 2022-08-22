using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Application
{
    class ListExercise
    {
        static void Main(string[] args)
        {
            List<int> Mylist = new List<int>();
            for (int i = 100; i <= 170; i++)
            {
                if (i%2==0)
                {
                    Mylist.Add(i);
                    Console.Write(" "+i);
                }
            }
            Console.ReadLine();
        }
    }
}
