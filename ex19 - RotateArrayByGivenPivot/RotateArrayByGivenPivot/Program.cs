using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateArrayByGivenPivot
{
    class Program
    {
        public static int[] RotateArrayByGivenPivot(int[] arr,int pivot)
        {
            
            int j = 0;
            int[] RotatedArray = new int[arr.Length];
            //second part of the array
            for (int i = pivot + 1; i < arr.Length; i++) //daca trebuia sa facem in oglinda, am fi pornit de la
            {                                            //i = arr.Length-1 ; i>=pivot;i--
                RotatedArray[j] = arr[i];
                j++;
            }

            //pivot
            RotatedArray[j] = arr[pivot];
            j++;

            //first part of the array
            for(int i=0;i<pivot;i++)  //daca trebuia sa le facem in oglinda, am fi pornit de la
            {                         // i= pivot-1;i>=0;i--
                RotatedArray[j] = arr[i];
                j++;
            }

            arr = RotatedArray;
            return arr;
        }

        public static void PrintArray(int[] arr)
        {
            foreach (int element in arr)
                Console.Write(element + " ");
                   Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            PrintArray(arr);


            Console.WriteLine("Choose a pivot between 0 and 8: ");
            int pivot = Convert.ToInt32(Console.ReadLine());
            arr = RotateArrayByGivenPivot(arr, pivot);
            PrintArray(arr);
            Console.ReadKey();

        }
    }
}
