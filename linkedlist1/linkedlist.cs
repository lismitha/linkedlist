using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkedlist1
{
    internal class linkedlist
    {
       static void Main()
       {
            string[] num = { "56", "30", "70" };
            Console.WriteLine("Displaying elements of a Linked List: ");
            LinkedList<string> myList = new LinkedList<string>(num);
            foreach (var num1 in myList)
            {
                Console.WriteLine(num1);
            }
       }
    }
}

