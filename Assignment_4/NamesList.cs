using System;
using System.Collections.Generic;

namespace List
{
    //class NamesList
    class NamesList
    {
        //created a names list
        List<string> namesList = new List<string>();

        //method to add name to the list
        public void AddName()
        {
            Console.WriteLine("Enter the name to Add : ");
            string name = Console.ReadLine();
            namesList.Add(name);
            Console.WriteLine("Name added Successfully");
        }

        //method to display names in the list
        public void DisplayNames()
        {
            //list empty condition
            if (namesList.Count == 0)
            {
                Console.WriteLine("No Names in the list");
            }
            //list is not empty
            else
            {
                Console.WriteLine("Names in the list : ");
                foreach (string name in namesList)
                {
                    Console.WriteLine(name);
                }
            }
        }

        //method to remove the name from the list using index
        public void RemoveName()
        {
            //empty list condition
            if (namesList.Count == 0)
            {
                Console.WriteLine("No Names in the list to remove ");
                return;
            }
            DisplayNames();//to display names in the list
            Console.Write("Enter the index of the name to remove: ");
            int index = Convert.ToInt32(Console.ReadLine());
            //index must be greater than or equal to zero and less than count of the list
            if (index < 0 || index > namesList.Count)
            {
                Console.WriteLine("Invalid index.");
                return;
            }
            namesList.RemoveAt(index);
            Console.WriteLine("Name removed successfully.");
            Console.WriteLine("Updated List...");

            DisplayNames();
        }

        //method to update name in the list
        public void UpdateName()
        {
            if (namesList.Count == 0)
            {
                Console.WriteLine("No names in the list to update");
                return;
            }
            DisplayNames();
            Console.WriteLine("Enter the index of the name to update :");
            int index = Convert.ToInt32(Console.ReadLine());
            //index must be greater than or equal to zero and less than count of the list
            if (index < 0 || index >= namesList.Count)
            {
                Console.WriteLine("Invalid index");
                return;
            }
            Console.WriteLine("Enter the new Name : ");
            string newName = Console.ReadLine();
            namesList[index] = newName;
            Console.WriteLine("Name updated Successfully");
            Console.WriteLine("Updated List...");
            DisplayNames();
        }

    }
}