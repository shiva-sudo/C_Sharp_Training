using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Application
{
    class Cons
    {
        public Cons()
        {
            Console.WriteLine("Constructor called for cons class.");
        }
        ~Cons()
        {
            Console.WriteLine("Destructor called ");
        }
    }
    //class MainMethod
    //{
    //    public static void Main(string[] args)
    //    {
    //        Cons c = new Cons();
    //        Cons c1 = new Cons();
    //        Console.ReadKey();
    //    }
    //}

}
