using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isNumberPalindrome
{
    class Program
    {
        public static bool isNumberPalindrome(int x)
        {
            int aux = x;
            int reversed = 0;
            while(aux!=0)
            {
                reversed = (reversed * 10) + (aux % 10);
                aux = aux/ 10;
            }
            if (reversed == x)
                return true;
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Read a number to see if it's a palindrome: ");
            int x = Convert.ToInt32(Console.ReadLine());
            if (isNumberPalindrome(x))
                Console.Write("The number " + x + " is a palindrome");
            else
                Console.Write("The number " + x + " is not a palindrome");

            Console.ReadKey();
        }
    }
}
