using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicatesFromString
{
    class Program
    {
        public static string RemoveDuplicates(string word)
        {
                return new string(word.ToCharArray().Distinct().ToArray());   
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Read a string with duplicates: ");
            string word = Console.ReadLine();
            string wordWithoutDuplicates = RemoveDuplicates(word);
            Console.Write("The string without duplicates is: " + wordWithoutDuplicates);
            Console.ReadKey();
        }
    }
}
