using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge2LinkedLists
{
    class Program
    {

        public static LinkedList<int> InitializareLista1()
        {
            LinkedList<int> list = new LinkedList<int>();

            LinkedListNode<int> firstNode = list.AddFirst(10);
            list.AddAfter(firstNode, 20); // list.AddAfter(list.First, 20);
            list.AddLast(30);
            list.AddLast(40);
            list.AddLast(50);
            return list;
        }

        public static LinkedList<int> InitializareLista2()
        {
            LinkedList<int> list = new LinkedList<int>();

            LinkedListNode<int> firstNode = list.AddFirst(40);
            list.AddLast(60);
            list.AddLast(60);
            list.AddLast(70);
            return list;
        }

        public static LinkedList<int> Merge2LinkedLists(LinkedList<int> list1, LinkedList<int> list2, LinkedList<int> list3)
        {
            list3.AddFirst(0);
            int i=0, j = 0;
            while(i<list1.Count || j<list2.Count)
            {
                if (i < list1.Count)
                    if (j < list2.Count)
                        while (list1.ElementAt(i) <= list2.ElementAt(j))
                        {
                            list3.AddLast(list1.ElementAt(i));
                            i++;
                            if (i == list1.Count)
                                break;
                        }
                    else
                        while (i < list1.Count)
                        { list3.AddLast(list1.ElementAt(i));
                          i++;
                        }

                if(j<list2.Count)
                    if(i<list1.Count)
                        while (list2.ElementAt(j)<=list1.ElementAt(i))
                        {
                            list3.AddLast(list2.ElementAt(j));
                            j++;
                            if (j == list2.Count)
                                break;
                        }
                    else
                        while(j<list2.Count)
                        {
                            list3.AddLast(list2.ElementAt(j));
                            j++;
                        }
                    
            }

            return list3;
        }

        public static void DisplayList(LinkedList<int> list)
        {
            foreach (var node in list)
                Console.Write(node + " ");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            LinkedList<int> list1 = InitializareLista1();
            LinkedList<int> list2 = InitializareLista2();
            LinkedList<int> list3 = new LinkedList<int>();
            Merge2LinkedLists(list1, list2, list3);
            DisplayList(list1);
            DisplayList(list2);
            DisplayList(list3);

            Console.ReadKey();

        }
    }
}
