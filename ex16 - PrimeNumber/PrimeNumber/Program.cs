using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{

    class Program
    {

        public static bool IsPrime(int x)
        {
            if (x == 0 || x == 1)
                return false;
            if (x == 2)
                return true;
            for (int i = 2; i <= x / 2; i++)
                if (x % i == 0)
                    return false;
            return true;
        }

        public static void Main()
        {
            Console.WriteLine("Read a number to check if it's prime: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (IsPrime(num) == true)
                Console.WriteLine("The number " + num + " is prime.");
            else
                Console.WriteLine("The number " + num + " is not prime.");

            Console.ReadKey();
        }
    }
}