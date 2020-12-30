using System;
using System.Text;
using System.Collections.Generic;

namespace HelperLibrary
{
    public static class Helpers
    {
        public static void PrintEnumerable<T>(IEnumerable<T> collection)
        {
            StringBuilder sb = new StringBuilder("[");
            foreach (var item in collection)
            {
                sb.Append(item.ToString() + ", ");
            }
            sb.Length = sb.Length - 2;
            sb.Append("]");

            Console.WriteLine(sb.ToString());
        }
    }
}