using System;
using System.Collections.Generic;
using HelperLibrary;

namespace _12._29._20
{
    class Program
    {
        // A permutation can be specified by an array P, where P[i] represents the location of the element at i in the permutation.
        // For example, [2, 1, 0] represents the permutation where elements at the index 0 and 2 are swapped.

        // Given an array and a permutation, apply the permutation to the array.
        // For example, given the array ["a", "b", "c"] and the permutation [2, 1, 0], return ["c", "b", "a"].
        static void Main(string[] args)
        {
            List<string> testArr1 = new List<string> { "a", "b", "c" };
            List<int> testPerm1 = new List<int> { 2, 1, 0 };
            List<string> testArr2 = new List<string> { "v", "w", "x", "y", "z" };
            List<int> testPerm2 = new List<int> { 2, 0, 3, 4, 1 };

            Helpers.PrintEnumerable<string>(PermuteArray(testArr1, testPerm1));
            Helpers.PrintEnumerable<string>(PermuteArray(testArr2, testPerm2));
        }

        public static List<string> PermuteArray(List<string> arr, List<int> perm)
        {
            List<string> result = new List<string>();

            for (int i = 0; i < perm.Count; i++)
            {
                result.Add(arr[perm[i]]);
            }

            return result;
        }
    }
}
