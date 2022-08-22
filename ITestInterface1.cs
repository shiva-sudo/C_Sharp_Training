using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Application
{
    interface ITestInterface1
    {
        void Add(int a, int b);
    }
    interface ITestInterface2:ITestInterface1
    {
        void Sub(int a, int b);
    }
    class ImplementaionClass : ITestInterface2
    {
        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void Sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        //static void Main()
        //{
        //    ImplementaionClass obj = new ImplementaionClass();
        //    obj.Add(60,80);
        //    obj.Sub(100, 50);
        //    Console.ReadLine();
        //}
    }
}
