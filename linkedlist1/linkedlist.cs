using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkedlist1
{
    internal class linkedlist
    {
      
     static void Main(string[] args)
     {
        LinkedList <int> L = new LinkedList<int>();
       
        L.AddFirst(30);
        L.AddFirst(56);
        L.AddFirst(70);
       
        Console.Write("Linked List elements are: ");
        foreach (int i in L)
        {
            Console.Write(i + " ");
        }
     }
  }
}

