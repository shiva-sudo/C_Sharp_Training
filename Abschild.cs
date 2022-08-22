using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Application
{
    class Abschild : Abstract
    {
        public override void mul(int x, int y)
        {
            Console.WriteLine("Multiplication of Abstract method Element x and y is : {0}",x * y);
        }
        public override void div(int x, int y)
        {
            Console.WriteLine("Division of Abstract method Element x and y is : {0}", x / y);
        }
        
    }
    
}
