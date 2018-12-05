using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rdElementFromTheEndLinkedList
{
    class Program
    {
        public static LinkedList<int> InitializareLista()
        {
            LinkedList<int> list = new LinkedList<int>();

            LinkedListNode<int> firstNode = list.AddFirst(10);
            list.AddAfter(firstNode, 20); // list.AddAfter(list.First, 20);
            list.AddLast(30);
            list.AddLast(30);
            list.AddLast(50);
            list.AddLast(60);

            return list;
        }
        public static void ThirdElementFromEndList(LinkedList<int> list)
        {
            for (int i = 0; i < list.Count; i++)
                if (list.Count - i == 3)
                {
                    Console.WriteLine("The 3rd element from the end of the list is: " + list.ElementAt(i));
                    break;
                } 
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
            DisplayList(list);
            ThirdElementFromEndList(list);
            Console.WriteLine(list.ElementAt(list.Count - 3)); // putem chiar sa nu parcurgem lista daca stim pe ce pozitie vrem sa merem
            Console.ReadKey();
           
        }
    }
}
