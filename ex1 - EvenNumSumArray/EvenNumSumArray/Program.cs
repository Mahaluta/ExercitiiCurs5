using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenNumSumArray
{
    
    class Program
    {
        public static int SumEvenNumbersArray(int[] arr)
        {
            int sum = 0;
            foreach (int element in arr)
                if (element % 2 == 0)
                    sum += element;
            return sum;
        }

        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("The sum of even elements in the array is: " + SumEvenNumbersArray(array));
            Console.ReadKey();
        }
    }
}
