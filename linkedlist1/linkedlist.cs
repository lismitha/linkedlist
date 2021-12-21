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
            my_list.AddLast(40);
            my_list.AddLast(65);
            my_list.AddLast(70);


            // Inital number of elements
            Console.WriteLine("number of the element :");

            // Accessing the elements of 
            // Linkedlist Using foreach loop
            foreach (int num in my_list)
            {
                Console.WriteLine(num);
            }

            // After using Remove(LinkedListNode)
            // method
            Console.WriteLine("remove the first element" + " the element is:");

            my_list.Remove(my_list.First);

            foreach (int num in my_list)
            {
                Console.WriteLine(num);
            }

        }
    }
}

