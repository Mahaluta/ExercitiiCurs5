using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseLinkedList
{
    class Program
    {

        public static LinkedList<int> InitializareLista()
        {
            LinkedList<int> list = new LinkedList<int>();

            LinkedListNode<int> firstNode = list.AddFirst(10);
            list.AddAfter(firstNode, 20);
            list.AddLast(30);
            list.AddLast(40);
            list.AddLast(50);
            return list;
        }

        public static LinkedList<int> ReverseList(LinkedList<int> list)
        {
            LinkedList<int> reversedList = new LinkedList<int>();

            foreach (int element in list)
                reversedList.AddFirst(element);
            //for (int i = list.Count - 1; i >= 0; i--)
            //    reversedList.AddLast(list.ElementAt(i));
            list = reversedList;
            return list;
               
        }

        public static void DisplayList(LinkedList<int> list)
        {
            foreach (var node in list)
                Console.Write(node + " ");
            Console.WriteLine();
        }


        static void Main(string[] args)
        {
            LinkedList<int> list = InitializareLista();
            Console.Write("Lista: ");
            DisplayList(list);
            Console.Write("Lista inversata: ");
            list = ReverseList(list);
            DisplayList(list);
            
            Console.ReadKey();

        }
    }
}
