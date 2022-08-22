using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Application
{
    class CQueue
    {
        static void Main(string[] args)
        {
            //// Defining THe queue 
            //Queue<int> queue = new Queue<int>();
            ////Enqueue Method to add items in queue
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);
            //queue.Enqueue(5);
            //queue.Enqueue(6);
            //// Printing the front value of the Queue
            //Console.WriteLine("The value of the front of the Queue is : {0}",queue.Peek());
            //foreach (int item in queue)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("Total Items in queue {0}",queue.Count());

            ////Dequeue method remove the items from the begining 
            //Console.WriteLine("The front Value {0} of the Queue Was removed ",queue.Dequeue());
            //foreach (int item in queue)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("Total Items in queue {0}", queue.Count());

            //Console.ReadLine();

            Queue<Order> ordersQueue = new Queue<Order>();
            foreach (Order o in RecieveOrdersFromBranch1())
            {
                // Add each orders to the Queue
                ordersQueue.Enqueue(o);
            }
            foreach (Order o in RecieveOrdersFromBranch2())
            {
                // Add each orders to the Queue
                ordersQueue.Enqueue(o);
            }
            // Checking the Queue is not empty
            while (ordersQueue.Count>0)
            {
                //Remove the order from the queue and store in a variable  called currentOrder
                Order currentOrder = ordersQueue.Dequeue();
                //process the order
                currentOrder.ProcessOrder();
            }
            Console.ReadLine();
        }
        static Order[] RecieveOrdersFromBranch1()
        {
            //Creating new Orders Array 
            Order[] orders = new Order[]
            {
                new Order(1,5),
                new Order(2,6),
                new Order(6,10)
            };
            return orders;
        }
        static Order[] RecieveOrdersFromBranch2()
        {
            //Creating new Orders Array and Intializing it with some orders of type order
            Order[] orders = new Order[]
            {
                new Order(3,8),
                new Order(4,3),
                new Order(5,11)
            };
            //return the array of orders that we created 
            return orders;
        }
    }
    class Order
    {
        public int OrderId { get; set; }
        public int OrderQuantity { get; set; }

        public Order(int id, int orderquantity)
        {
            this.OrderId = id;
            this.OrderQuantity = orderquantity;
        }
        public void ProcessOrder()
        {
            Console.WriteLine($"Order {OrderId} is Processed !");
        }
    }
   
}
