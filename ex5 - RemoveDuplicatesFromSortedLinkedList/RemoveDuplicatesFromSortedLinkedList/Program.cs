using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicatesFromSortedLinkedList
{
    class Program
    {
        public static LinkedList<int> InitializareLista()
        {
            LinkedList<int> list = new LinkedList<int>();

            LinkedListNode<int> firstNode = list.AddFirst(10);
            list.AddAfter(firstNode, 10); // list.AddAfter(list.First, 20);
            list.AddLast(20);
            list.AddLast(20);
            list.AddLast(50);
            return list;
        }

        /* Daca ar fi trebuit luam lista ca si input, am fi procedat astfel:
         * 1) introducem primul element
         * 2) introducem al doilea element in functie de primul ( > sau < )
         * 3) introducem restul elementelor pe pattern-ul:
         *          while(list.ElementAt(i) < elementCitit && list.ElementAt(i+1) > elementCitit) i++;
         *          Adaugam elementul citit in functie de index-ul i;
         */

        public static void DisplayList(LinkedList<int> list)
        {
            foreach (var node in list)
                Console.Write(node + " ");
        }

        public static void RemoveDuplicates(LinkedList<int> list)
        {
            for (int i = 0; i < list.Count - 1; i++)
                while (list.ElementAt(i) == list.ElementAt(i+1))
                    list.Remove(list.ElementAt(i));

        }

        static void Main(string[] args)
        {
            LinkedList<int> list = InitializareLista();
            DisplayList(list);
            Console.WriteLine();
            RemoveDuplicates(list);
            DisplayList(list);
            Console.ReadKey();
        }
    }
}
