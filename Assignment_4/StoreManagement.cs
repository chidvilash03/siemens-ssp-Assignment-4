using System;
using System.Collections.Generic;

namespace Queue
{
    //class StoreManagement
    class StoreMangement
    {
        //created queue using collection
        Queue<string> queue = new Queue<string>();

        //method to add customer into the queue
        public void AddCustomer()
        {
            Console.WriteLine("Enter the Customer name : ");
            string customer = Console.ReadLine();
            queue.Enqueue(customer);
            Console.WriteLine("Customer added successfully");
        }

        //method to serve customer in the queue
        public void ServeCustomer()
        {
            if (queue.Count == 0)
            {
                Console.WriteLine("Queue is Empty. No Customer to serve");
                return;
            }
            string servedCustomer = queue.Dequeue();
            Console.WriteLine("Serving Customer : " + servedCustomer);
        }

        //method to display the number of customers in the queue
        public void QueueCount()
        {
            Console.WriteLine("Number of Customers in the Queueu : " + queue.Count);
        }

        //method to clear the queue
        public void ClearQueue()
        {
            queue.Clear();
            Console.WriteLine("The Customer Queue is Cleared Successfully ");
        }
    }

}
