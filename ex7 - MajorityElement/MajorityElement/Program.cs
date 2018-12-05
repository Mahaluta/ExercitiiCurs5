using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MajorityElement
{
    class Program
    {
        public static void MajorityElement(int[] arr)
        {
            int maxCount = 0; int counter; int index = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                counter = 0;
                for (int j = 0; j < arr.Length; j++)
                    if (arr[i] == arr[j])
                        counter++;

                if (counter > maxCount)
                {
                    maxCount = counter;
                    index = i;
                }



            }
            if (maxCount > arr.Length / 2)
                Console.Write("The majority element is: " + arr[index]);
            else
                Console.WriteLine("There's no majority element in this array.");
        }
        

        public static void PrintArray(int[] arr)
        {
                foreach (int element in arr)
                    Console.Write(element + " ");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int[] arr = new int[] { 1,2,1,1,1,1,3,4,4,1,10 };
            PrintArray(arr);
            MajorityElement(arr);
            
            Console.ReadKey();

        }
    }
}
