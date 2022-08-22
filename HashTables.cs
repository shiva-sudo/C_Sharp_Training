using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Application
{
    class Student
    {
        public int ID { get; set; }
        public string  Name { get; set; }
        public float GPA { get; set; }

        public Student(int id,string name,float GPA)
        {
            ID = id;
            Name = name;
            this.GPA = GPA;

        }
    }
    class HashTables
    {
        static void Main(string[] args)
        {
            Hashtable studentTable = new Hashtable();
            Student stud1 = new Student(1,"Maria",68);
            Student stud2 = new Student(2, "jonsan", 78);
            Student stud3 = new Student(3, "Lucy", 45);
            Student stud4 = new Student(4, "stefen", 38);
            Student stud5 = new Student(5, "Clara", 54);

            studentTable.Add(stud1.ID, stud1);
            studentTable.Add(stud2.ID, stud2);
            studentTable.Add(stud3.ID, stud3);
            studentTable.Add(stud4.ID, stud4);
            studentTable.Add(stud5.ID, stud5);

            // Rettrive All Values from a hashtasble 
            // DictionaryEntry define key/value pair
            // Entry is variable of DictionaryEntry. 

            foreach(DictionaryEntry entry in studentTable)
            {
                // Here We are Creating a Temp Variable for Student class and value is a Getter and Setter Method.

                Student temp =(Student)entry.Value;
                Console.WriteLine("Student ID is : {0} ",temp.ID);
                Console.WriteLine("Student Name  is : {0} ", temp.Name);
                Console.WriteLine("Student GPA is : {0} ", temp.GPA);
            }
            // Here  we are Itrating the data without  Creating variable 
            foreach (Student value in studentTable)
            {
                Console.WriteLine("Student ID is : {0} ", value.ID);
                Console.WriteLine("Student Name  is : {0} ", value.Name);
                Console.WriteLine("Student GPA is : {0} ", value.GPA);
            }
            Console.ReadLine();
        }
    }
}
