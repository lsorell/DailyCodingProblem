using System;
using System.Collections.Generic;

namespace _11._09._20
{
    class Program
    {
        // Given a string, determine whether any permutation of it is a palindrome.
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome("carrace"));
            Console.WriteLine(IsPalindrome("daily"));
            Console.WriteLine(IsPalindrome("nnaa"));
            Console.WriteLine(IsPalindrome("level"));
        }

        public static bool IsPalindrome(string str)
        {
            HashSet<char> hs = new HashSet<char>();
            
            foreach(char c in str)
            {
                if(hs.Contains(c))
                {
                    hs.Remove(c);
                }
                else
                {
                    hs.Add(c);
                }
            }
            
            return (str.Length % 2 == 0) ? hs.Count == 0 : hs.Count <= 1;
        }
    }
}
