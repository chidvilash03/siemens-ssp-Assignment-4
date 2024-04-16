using System;
using Dictionary;
using List;
using Queue;
using Stack;

namespace Collections
{
    //class program
    class Program
    {
        //method to do list operations
        public void ComputeListOperations()
        {
            bool exit = false;
            NamesList list = new NamesList();
            while (!exit)
            {
                //menu 
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Add a new name");
                Console.WriteLine("2. Display all names");
                Console.WriteLine("3. Remove a name by index");
                Console.WriteLine("4. Update a name by index");
                Console.WriteLine("5. Exit");

                //taking input from user
                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                //switch case to do operation according to the choice
                switch (choice)
                {
                    case 1:
                        list.AddName();
                        break;
                    case 2:
                        list.DisplayNames();
                        break;
                    case 3:
                        list.RemoveName();
                        break;
                    case 4:
                        list.UpdateName();
                        break;
                    case 5:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                        break;

                }

            }

        }

        //method to do dictionary operations
        public void ComputeDictionaryOperations()
        {
            bool exit = false;
            WordsDictionary dictionary = new WordsDictionary();

            while (!exit)
            {
                //menu
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Add a new word");
                Console.WriteLine("2. Display all words and meanings");
                Console.WriteLine("3. Search Meaning of a word");
                Console.WriteLine("4. Remove a word from dictionary");
                Console.WriteLine("5. Exit");

                //taking input of choice from the user
                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                //switch case to do operation according to the users choice
                switch (choice)
                {
                    case 1:
                        dictionary.AddWord();
                        break;
                    case 2:
                        dictionary.DisplayWords();
                        break;
                    case 3:
                        dictionary.SearchMeaning();
                        break;
                    case 4:
                        dictionary.RemoveWord();
                        break;

                    case 5:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                        break;

                }

            }
        }

        //method to do queue operations
        public void ComputeQueueOperations()
        {
            bool exit = false;

            StoreMangement queue = new StoreMangement();

            while (!exit)
            {
                //menu
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Add a new customer to the queue");
                Console.WriteLine("2. Serve the next customer in the queue");
                Console.WriteLine("3. Display the current number of customers in the queue");
                Console.WriteLine("4. Clear the entire queue");
                Console.WriteLine("5. Exit");

                //taking input choice from the user
                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                //switch case to do the operation according to the user choice
                switch (choice)
                {
                    case 1:
                        queue.AddCustomer();
                        break;
                    case 2:
                        queue.ServeCustomer();
                        break;
                    case 3:
                        queue.QueueCount();
                        break;
                    case 4:
                        queue.ClearQueue();
                        break;
                    case 5:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                        break;
                }
            }
        }

        //method to do stack operations
        public void ComputeStackOperations()
        {
            bool exit = false;

            IntegersStack stack = new IntegersStack();

            while (!exit)
            {
                //menu
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Push a new number onto the stack");
                Console.WriteLine("2. Pop the top number from the stack");
                Console.WriteLine("3. Display the top number without removing it");
                Console.WriteLine("4. Check if the stack is empty");
                Console.WriteLine("5. Exit");

                //taking choice input from the user
                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                //switch case to do the operation according to the choice
                switch (choice)
                {
                    case 1:
                        stack.PushIntoStack();
                        break;
                    case 2:
                        stack.PopFromStack();
                        break;
                    case 3:
                        stack.DisplayTop();
                        break;
                    case 4:
                        stack.IsStackEmpty();
                        break;
                    case 5:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid Choice !.Please enter a number from 1 to 5");
                        break;
                }
            }


        }

        //main method
        public static void Main()
        {
            //uncomment the below lines to execute List Exercise 
            //Program exercise1 = new Program();
            //exercise1.ComputeListOperations();

            //uncomment the below line to execute Dictionary Exercise
            //Program exercise2 = new Program();
            //exercise2.ComputeDictionaryOperations();

            //uncomment the below lines to execute Queue Exercise
            //Program exercise3 = new Program();
            //exercise3.ComputeQueueOperations();

            //uncomment the below lines to execute Stack Exercise
            //Program exercise4 = new Program();
            //exercise4.ComputeStackOperations();
        }
    }

}