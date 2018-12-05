using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class Program
    {
        public static void SelectionSort(int[] arr)
        {
            int indexMin, aux;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                indexMin = i;
                for (int j = i + 1; j < arr.Length; j++)
                   if (arr[j] < arr[indexMin])
                        indexMin = j;
                   
                if (indexMin != i)
                {
                    aux = arr[i];
                    arr[i] = arr[indexMin];
                    arr[indexMin] = aux;
                }
            }
        }

        public static void PrintArray(int[] arr)
        {
            foreach (int element in arr)
                Console.Write(element + " ");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] arr = new int[] { 3, 2, 4, 1, 6, 5 };
            PrintArray(arr);
            SelectionSort(arr);
            PrintArray(arr);

            Console.ReadKey();

        }
    }
}
