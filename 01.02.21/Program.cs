using System;
using System.Collections.Generic;
using HelperLibrary;

namespace _01._02._21
{
    class Program
    {
        // Given a string and a pattern, find the starting indices of all occurrences of the pattern in the string.
        // For example, given the string "abracadabra" and the pattern "abr", you should return [0, 7].
        static void Main(string[] args)
        {
            Helpers.PrintEnumerable<int>(FindAllPatterns("aaaaaa", "aa"));
            Helpers.PrintEnumerable<int>(FindAllPatterns("abracadabra", "abr"));
            Helpers.PrintEnumerable<int>(FindAllPatterns("freedomfreeters", "free"));
        }

        public static List<int> FindAllPatterns(string str, string pattern)
        {
            List<int> matches = new List<int>();
            for (int i = 0; i < str.Length; i++)
            {
                if (str.Substring(i).Length < pattern.Length)
                {
                    break;
                }
                if (str[i] == pattern[0])
                {
                    bool match = true;
                    int k = i + 1;
                    for (int j = 1; j < pattern.Length; j++)
                    {
                        if (str[k] != pattern[j])
                        {
                            match = false;
                            break;
                        }
                        k++;
                    }
                    if (match)
                    {
                        matches.Add(i);
                    }
                }
            }
            return matches;
        }
    }
}
