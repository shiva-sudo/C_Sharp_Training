using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Application
{
    public class Phone
    {
        public string Company;
        public string Model;
        public string ReleaseDay;

        // Place for your constructors
        public Phone()
        {
            Company = "Unknown";
            Model = "Unknown";
            ReleaseDay = "Unknown";
        }
        public Phone(string company,string model)
        {
            Company = company;
            Model = model;
        }
        public Phone(string company, string model ,string Releaseday)
        {
            Company = company;
            Model = model;
            ReleaseDay = Releaseday;
        }
        public void Introduce()
        {
            Console.WriteLine("It is {0} created by {1}. It was released {2}.", Model, Company, ReleaseDay);
        }

    }

    public class Run
    {
        public static void Main()
        {
            Phone one = new Phone();
            Phone two = new Phone("Apple", "IPhone 12");
            Phone three = new Phone("Apple", "IPhone 12", "September 24, 2021");

            one.Introduce();
            two.Introduce();
            three.Introduce();
            Console.ReadLine();

        }

    }
}


