using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Application
{
    class ReadFromTextFile
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"C:\C Sharp Trainning\Demo_Application\text.txt");
            Console.WriteLine(" Text file contain following text : {0}", text);
            string[] lines = System.IO.File.ReadAllLines(@"C:\C Sharp Trainning\Demo_Application\text.txt");
            Console.WriteLine(" Text file contain following text : ");
            foreach (string  line in lines)
            {
                Console.WriteLine("\t"+line);
            }
            Console.ReadLine();
        }
    }
}
