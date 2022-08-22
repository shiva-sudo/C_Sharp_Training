using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Application
{
    class GFG
    {
        public string Name;
        public string Subject;

        //Public Method Of Parent Class
        public void Reader(string name,string subject)
        {
            name = Name;
            subject = Subject;
            Console.WriteLine("My Name is : " + name);
            Console.WriteLine("My  Favorite Subject is : " + subject);
        }
    }
    class Geeks:GFG
    {
        //Constructor  of Derived Class
        public Geeks()
        {
            Console.WriteLine("Child Class constructor called ");
        }
    }

    // Driver Class
    class Inharitance
    {
        static void Main(string[] args)
        {
            Geeks g = new Geeks();
            g.Reader("shiva","C#");
            Console.ReadLine();
        }
    }
}
