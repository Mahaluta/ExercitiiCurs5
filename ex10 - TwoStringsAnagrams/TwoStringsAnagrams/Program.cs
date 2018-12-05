using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoStringsAnagrams
{
    class Program
    {

        

        public static bool CheckAnagram(string word1,string word2)
        {
            char[] arr1 = word1.ToCharArray();
            char[] arr2 = word2.ToCharArray();
            Array.Sort(arr1);
            Array.Sort(arr2);
           

            for (int i = 0; i < arr1.Length; i++)
                if (arr1[i] != arr2[i])
                    return false;
            return true;
        }

        

        static void Main(string[] args)
        {
            Console.WriteLine("Read two strings of the same dimension to see if they're anagrams: ");
            string word1 = Console.ReadLine();
            string word2 = Console.ReadLine();
            if (CheckAnagram(word1.ToLower(), word2.ToLower()))
                Console.WriteLine("The words " + word1 + " and " + word2 + " are angarams.");
            else
                Console.WriteLine("The words " + word1 + " and " + word2 + " are not angarams.");

            Console.ReadKey();
           

        }
    }
}
