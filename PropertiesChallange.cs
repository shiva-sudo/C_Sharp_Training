using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Application
{
    class Members
    {
        string memberName;
        string jobTitle;
        int salary=20000;
        public int age;

        public string JobTitle
        {
            get { return jobTitle; }
            set { jobTitle = value; }
        }
        public void Introducing(bool isFriend)
        {
            if (isFriend)
            {
                SharingPrivateInfo();
            }
            else
            {
                Console.WriteLine("Hi my name is {0},and my job title is {1} I'm {2} year old",memberName,jobTitle,age);
            }
        }
        private void SharingPrivateInfo()
        {
            Console.WriteLine("Hi my name is {0},and my job title is {1} I'm {2} year old and My salary is {3}", memberName, jobTitle, age,salary);
        }
        public Members()
        {
            age = 30;
            memberName = "Luccy";
            salary = 600000;
            jobTitle = "Developer";
            Console.WriteLine("Object Created");
        }
        ~Members()
        {
            Console.WriteLine("Deconstructore called");
        }
    }
    class PropertiesChallange
    {
        static void Main(string[] args)
        {
            Members member1 = new Members();
            member1.Introducing(true);
            Console.ReadKey();
        }
    }
}
