using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a Program that  will Itrate through each Element of the students arrays and insert them into A Hashtable
//if a student fwith  the same ID already exist in the Hashtable skip it and display the following error
//"Sorry .A student with the same ID already Exists."


namespace Demo_Application
{
    class Student1
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public float GPA { get; set; }

        public Student1(int id, string name, float GPA)
        {
            ID = id;
            Name = name;
            this.GPA = GPA;

        }
    }
    class HashTableChallange
    {
        static void Main(string[] args)
        {
            Hashtable table = new Hashtable();
            // Creating a Array 
            Student1[] students = new Student1[5];
            students[0] = new Student1(1, "Maria", 68);
            students[1] = new Student1(2, "jonsan", 78);
            students[2] = new Student1(3, "Lucy", 45);
            students[3] = new Student1(3, "stefen", 38);
            students[4] = new Student1(5, "Clara", 54);

            foreach (Student1 s in students)
            {
                if (!table.ContainsKey(s.ID))
                {
                    table.Add(s.ID, s);
                    Console.WriteLine("Student with ID {0} was Added!.",s.ID);
                }
                else
                {
                    Console.WriteLine("Sorry, A student with the same ID already Exist ID = {0}",s.ID);
                }
            }
            Console.ReadLine();
        }
        
    }
}
