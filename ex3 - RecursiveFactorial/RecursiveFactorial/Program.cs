using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveFactorial
{
    class Program
    {
          public static int RecursiveFactorial(int x)
        {
            if (x < 2)
                return 1;
            else return x * RecursiveFactorial(x - 1);
        }
        static void Main(string[] args)
        {
            Console.Write("Read a positive number to see his factorial: ");
            int x;
            while (true)
            {
                x = Convert.ToInt32(Console.ReadLine());
                if(x<0)
                {
                    Console.WriteLine("Read a positive number: ");
                    continue;
                }
                break;
            }
            
            Console.WriteLine("The factorial of " + x + " is: " + RecursiveFactorial(x));
            // RecursiveFactorial nu este eficienta pentru ca la fiecare apel trebuie sa returneze adrese si argumente pe stack si ia mai mult timp
            // mai eficient decat recursive ar fi:
            
            /* int factorial(int x) {
                  int result = 1;
                  while (x > 1) {
                   result *= n;
                   n--; 
                   }
                   return result;
                   } 
            */

            Console.ReadKey();
        }
    }
}
