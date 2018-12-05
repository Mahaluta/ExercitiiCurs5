using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountNumberOfBits1
{
    class Program
    {
        public static int CountBits1(int num)
        {
            int sum = 0;
            int CurrentBit = 0;
            for (int i = 0; i < 32; i++)
            {  CurrentBit = num & (1 << i);  //se pune un mask de forma 00001(pe pozitia i)000 peste numarul 'num' pe biti si se face conjunctie
                if (CurrentBit != 0)       // care in cazul acesta poate fi doar 0 sau 1;
                    sum++;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.Write("Read a number to see how many bits(1) it has: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write(CountBits1(num));
            Console.ReadKey();
        }
    }
}
