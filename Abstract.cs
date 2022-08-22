using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Application
{
    abstract class Abstract
    {
        //This is the non-Abstract Method

        public void Add(int x, int y)
        {
            Console.WriteLine("Addition of x and y is : {0}", x + y);
        }
        public void Sub(int x, int y)
        {
            Console.WriteLine("Subtraction of x and y is : {0}", x - y);
        }

        // This is The Abstarct Method
        public abstract void mul(int x, int y);
        public abstract void div(int x, int y);
    }

}
