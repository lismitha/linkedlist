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
            LinkedList<int> numList = new LinkedList<int>();
            numList.AddLast(30);
            LinkedListNode<int> numNode = numList.AddLast(46);
            LinkedListNode<int> num1Node = numList.AddLast(70);
            Console.WriteLine("LinkedList Elements");
            Print(numList);

            numList.AddBefore(numNode, 60);
            Console.WriteLine($"LinkedList Elements After AddBefore({numNode.Value},'60')");
            Print(numList);

            numList.AddBefore(num1Node, 65);
            Console.WriteLine($"LinkedList Elements After AddBefore({num1Node.Value},'65')");
            Print(numList);
        }


        private static void Print(LinkedList<int> list)
        {
            foreach (var node in list)
            {
                Console.Write(node + ", ");
            }
            Console.WriteLine("\n");
        }
    }
}