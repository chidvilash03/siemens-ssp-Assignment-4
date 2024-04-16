using System;
using System.Collections.Generic;

namespace Stack
{
    //class IntegersStack
    class IntegersStack
    {
        //created integer stack unsing collection
        Stack<int> integersStack = new Stack<int>();

        //method to push the integer into the stack
        public void PushIntoStack()
        {
            Console.WriteLine("Enter a number to push into the stack");
            int number = Convert.ToInt32(Console.ReadLine());
            integersStack.Push(number);
            Console.WriteLine("Number pushed into the stack successfully");
        }

        //method to pop the integer from the stack
        public void PopFromStack()
        {
            //condition to check the stack is empty or not
            if (integersStack.Count == 0)
            {
                Console.WriteLine("Stack is Empty");
                return;
            }

            int poppedInteger = integersStack.Pop();
            Console.WriteLine("Number " + poppedInteger + " popped from the stack successfully");
        }

        //method to display the peek element in the stack
        public void DisplayTop()
        {
            //condition to check the stack is empty or not
            if (integersStack.Count == 0)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            int peek = integersStack.Peek();
            Console.WriteLine("Top Number : " + peek);
        }

        //method to check the stack is empty or not
        public void IsStackEmpty()
        {
            if (integersStack.Count == 0)
            {
                Console.WriteLine("Stack is Empty");
            }
            else
            {
                Console.WriteLine("Stack is Not Empty");
            }
        }
    }
}
