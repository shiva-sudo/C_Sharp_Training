using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Application
{
    class EmployeeDictionary
    {
        public string Role { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public float Rate { get; set; }

        public float Salary
        {
            get
            {
                return Rate * 8 * 5 * 4 * 12;
            }
        }
        public EmployeeDictionary(string role, string name, int age, float rate)
        {
            this.Role = role;
            this.Name = name;
            this.Age = age;
            this.Rate = rate;
        }
    }
    class DictionaryDemo
    {
        static void Main(string[] args)
        {
            EmployeeDictionary[] employees = {
                new EmployeeDictionary("CEO","Gwyn",78,200),
                new EmployeeDictionary("Manager","Gems",45,20),
                new EmployeeDictionary("HR","David",34,22),
                new EmployeeDictionary("Developer","Merlin",58,50),
                new EmployeeDictionary("Lead","larry",43,12),
                new EmployeeDictionary("Intern","Merry",43,12)
            };
            Dictionary<int, string> dictionary = new Dictionary<int, string>()
            {
                {1,"One" },
                {2,"Two " },
                {3,"Three" },
                {4,"Four" }
            };
            Dictionary<string, EmployeeDictionary> empDictionary = new Dictionary<string, EmployeeDictionary>();
            foreach (EmployeeDictionary emp in employees)
            {
                empDictionary.Add(emp.Role, emp);
            }


            // ******UPDATE******

            string KeyToUpdate = "HR";  
            if (empDictionary.ContainsKey(KeyToUpdate))
            {
                //Syntax : -
                //<DictionaryName >   [KeyName ] = new <Class name >(Assign the vlaue )
                empDictionary[KeyToUpdate] = new EmployeeDictionary("HR", "Elkin", 34, 22); 
                Console.WriteLine("Emplooyee with Role/Key {0} was Updated !",KeyToUpdate);
            }
            else
            {
                // Print the Error Message 
                Console.WriteLine("Sorry ! No Employee Found with this Key {0}",KeyToUpdate);
            }


            //***************** REMOVE *************

            string KeyToRemove = "Intern";
            if (empDictionary.Remove(KeyToRemove))
            {
                Console.WriteLine("Emplooyee with Role/Key {0} was Removed !", KeyToRemove);
            }

            //***********Itrate the Element *********
            for (int i = 0; i < empDictionary.Count; i++)
            {
                //using Elementat(i) to return the key pair stored in the index i 
                KeyValuePair<String, EmployeeDictionary> keyValuePair = empDictionary.ElementAt(i);
                //This line wil print stored key 
                Console.WriteLine("key {0}",keyValuePair.Key);
                //Storing the value on an EmployeeDictionary Object (employeevalue)
                EmployeeDictionary employeValue = keyValuePair.Value;
                Console.WriteLine("Employee Name is {0}",employeValue.Name);
                Console.WriteLine("Employee Age is {0}", employeValue.Age);
                Console.WriteLine("Employee Role is {0}", employeValue.Role);
                Console.WriteLine("Employee salary is {0}", employeValue.Salary);
            }

            //Using Contains Key it return the value 
            //this is first method to return the valve
            string Key = "CEO";
            if (empDictionary.ContainsKey(Key))
            {
                EmployeeDictionary emp1 = empDictionary[(Key)];
                Console.WriteLine("Employee Name :{0} ,Role :{1}, Age : {2}, Salary : {3}",emp1.Name,emp1.Role,emp1.Age,emp1.Salary);
            }
            else
            {
                Console.WriteLine("No Employee found witih this key");
            }

            //Using TryGetValue it return the value 
            //TryGetValue return bool value
            //this is first method to return the value
            EmployeeDictionary result = null;
            if (empDictionary.TryGetValue("Intern",out result))
            {
                Console.WriteLine("Value Retrived !");
                Console.WriteLine("Employee Name is {0}", result.Name);
                Console.WriteLine("Employee Age is {0}", result.Age);
                Console.WriteLine("Employee Role is {0}", result.Role);
                Console.WriteLine("Employee salary is {0}", result.Salary);
            }
            else
            {
                Console.WriteLine("The Key Does not exist");
            }
            Console.ReadLine();
        }
    } 
    
}
