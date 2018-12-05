using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumDigitsForANumber
{
    class Program
    {
        public static int SumDigits(int num)
        {
            int sum = num%10;
            if (num == 0)
                return 0;
            else
                sum = sum + SumDigits(num / 10);
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Read a number to sum his digits: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(SumDigits(num));
            Console.ReadKey();
        }
    }
}
