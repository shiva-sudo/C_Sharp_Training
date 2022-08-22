using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Application
{
    class CStack
    {
        static void Main(string[] args)
        {
            //Defining a new stack
            Stack<int> stack = new Stack<int>();

            // Add Element tp the stack using Push()
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);

            Console.WriteLine("Stack Element is .....");
            foreach (int  item in stack)
            {
                Console.WriteLine(item);
            }

            //Remove items from Stack 
            int MystackItem = stack.Pop();

            Console.WriteLine("Poped Item is : {0}",MystackItem);
            Console.WriteLine("Stack Element is .....");
            foreach (int item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Element at the Top : {0}",stack.Peek());


            //Check the condition count is greater than 0 then remove item from stack 
            //while (stack.Count>0)
            //{
            //    Console.WriteLine("The Top value {0} was removed from the stack",stack.Pop());
            //    Console.WriteLine("Element at the Top : {0}", stack.Peek());
            //}

            Stack<int> myStack = new Stack<int>();
            int[] numbers = new int[] { 2,5,4,8,7,4,5,6,9};
            Console.WriteLine("The Numbers in the array are : ");
            foreach (int  number in numbers)
            {
                Console.Write(number + " ");

                // Push it into Stack (Add)
                myStack.Push(number);
            }
            Console.WriteLine(" ");
            Console.WriteLine("The number in revrse : ");
            while (myStack.Count>0)
            {
                //Pop it and store into the variable 
                int number = myStack.Pop();

                // Print the stored value. But in reverse Order
                Console.Write(number+ " ");
            }
            Console.ReadLine();
        }
    }
}
