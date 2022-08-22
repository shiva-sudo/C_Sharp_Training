using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Application
{
    class Matrix
    {
        int a, b, c, d;
        public Matrix(int a, int b, int c, int d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }
        public static Matrix operator +(Matrix Obj1 ,Matrix Obj2)
        {
            Matrix obj = new Matrix(Obj1.a + Obj2.a, Obj1.b + Obj2.b, Obj1.c + Obj2.c, Obj1.d + Obj2.d);
            return obj;
        }
        public override string ToString()                              //method overriding 
        {
            return a + " " + b + "\n" + c + " " + d + "\n"; 
        }

    }
        class TestMatrix
        {
        //static void Main()
        //{
        //    Matrix M1 = new Matrix(10, 34, 15, 7);
        //    Matrix M2 = new Matrix(16, 18, 8, 9);
        //    Matrix M3 = M1 + M2;
        //    Console.WriteLine(M1);
        //    Console.WriteLine(M2);
        //    Console.WriteLine(M3);
        //    Console.ReadKey();

        //}
        }
    
}
 