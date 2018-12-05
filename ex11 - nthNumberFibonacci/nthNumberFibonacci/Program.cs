using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nthNumberFibonacci
{
    class Program
    {
        public static int nthFibonacci(int num)
        {
            int a = 0, b = 1, aux;
            if (num == 0)
                return a;
            for (int i = 2; i <= num; i++)
            {
                aux = a + b;
                a = b;
                b = aux;
            }
            return b;
        }


    
    static void Main(string[] args)
        {
            Console.WriteLine("Read a number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The " + x + "th number in Fibonacci series is: " + nthFibonacci(x));
            Console.ReadKey();
        }
    }
}
