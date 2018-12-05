using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairsOfElementsThatAreEqualToANumber
{
    class Program
    {

        public static void BubbleSort(int[] arr)
        {

            for (int i = 0; i < arr.Length - 1; i++)
                for (int j = i+1; j < arr.Length; j++)
                    if (arr[i] > arr[j])
                        swap(arr, i, j);
        }
        
        public static void swap(int[] arr,int i, int j)
        {
            int aux;
            aux = arr[i];
            arr[i] = arr[j];
            arr[j] = aux;
        }

        public static void PrintArray(int[] arr)
        {

            foreach (int element in arr)
                Console.Write(element + " ");
        }

        public static void CheckPairsOfElements(int[] arr,int sum)
        {
            int ok = 0;
            int leftIndex = 0;
            int rightIndex = arr.Length - 1;
            while (leftIndex < rightIndex)
            {
                while (arr[leftIndex] + arr[rightIndex] <= sum && leftIndex < rightIndex)
                {
                    if (arr[leftIndex] + arr[rightIndex] == sum)
                    {
                        Console.WriteLine("A pair of elements that have this sum is: " + arr[leftIndex] + " " + arr[rightIndex]);
                        ok = 1;
                    }
                    leftIndex++;
                }
                while(arr[leftIndex] + arr[rightIndex] >= sum && leftIndex < rightIndex)
                {
                    if (arr[leftIndex] + arr[rightIndex] == sum)
                    {
                        Console.WriteLine("A pair of elements that have this sum is: " + arr[leftIndex] + " " + arr[rightIndex]);
                        ok = 1;
                    }
                    rightIndex-- ;
                }

                if (ok == 0)
                    Console.WriteLine("Couldn't find any pairs in this array with the sum: " + sum);


            }
        }

        static void Main(string[] args)
        {
            int[] arr = new int[] { 2, 7, 4, 5, 3, 3, 10};
            PrintArray(arr);
            BubbleSort(arr);
            

            Console.WriteLine();

            Console.WriteLine("Read the number to see if there can be a sum of elements in this array equal to that number: ");
            int sum = Convert.ToInt32(Console.ReadLine()); // preferabil: 9

            CheckPairsOfElements(arr,sum);

            Console.ReadKey();
            

        }
    }
}
