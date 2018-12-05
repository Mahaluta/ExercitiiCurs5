using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckDuplicatesArray
{
    class Program
    {
        public static bool CheckDuplicatesArray(int[] arr) {
            for (int i = 0; i < arr.Length; i++)
                for (int j = i + 1; j < arr.Length; j++)
                    if (arr[i] == arr[j])
                        return true;
            return false;
            }
        public static void PrintArray(int[] arr)
        {
            foreach (int element in arr)
                Console.Write(element + " ");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 1, 2, 2, 3, 4, 5, 6 };
            PrintArray(arr);
            if (CheckDuplicatesArray(arr))
                Console.WriteLine("There are duplicates in the array.");
            else
                Console.WriteLine("There are no duplicates in the array.");
            Console.ReadKey();
        }
    }
}
