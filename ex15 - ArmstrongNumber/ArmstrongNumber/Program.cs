using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmstrongNumber
{
    class Program
    {
        public static bool ArmstrongNumber (int x){
            if (x == 0 || x == 1)
                return true;
            int a, b, c;
            a = x % 10;
            b = x % 100 / 10;
            c = x % 1000 / 100;
            if (Math.Pow(a, 3) + Math.Pow(b, 3) + Math.Pow(c, 3) == x)
                return true;
            return false;
            }

        static void Main(string[] args)
        {
            Console.WriteLine("Read a 3 digits positive number to see if it's an Armstrong number: ");
            int x = Convert.ToInt32(Console.ReadLine()); // 0, 1, 153, 370, 371, 407 (numere Armstrong)
            while (true)
            {
                if (x < 0 || x > 999)
                {
                    Console.Write("Read a 3 digits positive number: ");
                    x = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    continue;
                }
                break;
            }
            
            if (ArmstrongNumber(x))
                Console.Write("The number " + x + " is an Armstrong number");
            else
                Console.Write("The number " + x + " is not an Armstrong number");

            Console.ReadKey();

        }
    }
}
