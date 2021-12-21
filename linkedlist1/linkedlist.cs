using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkedlist1
{
    internal class linkedlist
    {

        // Main Method
        static public void Main()
        {

            // Creating a linkedlist
            // Using LinkedList class
            LinkedList<int> my_list = new LinkedList<int>();

            // Adding elements in the LinkedList
            // Using AddLast() method
            my_list.AddLast(36);
            my_list.AddLast(50);
            my_list.AddLast(45); 

            Console.WriteLine("the numbers in the list are :");

            // Accessing the elements of 
            // LinkedList Using foreach loop
            foreach (int num in my_list)
            {
                Console.WriteLine(num);
            }
        }
    }
}