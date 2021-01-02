using System;

namespace _01._01._21
{
    class Program
    {
        /*
        A Collatz sequence in mathematics can be defined as follows. Starting with any positive integer:

        if n is even, the next number in the sequence is n / 2
        if n is odd, the next number in the sequence is 3n + 1
        It is conjectured that every such sequence eventually reaches the number 1. Test this conjecture.

        Bonus: What input n <= 1000000 gives the longest sequence?
        */
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine(IsCollatz(1, out count));
            Console.WriteLine(IsCollatz(10, out count));
            Console.WriteLine(IsCollatz(1000, out count));
            Console.WriteLine(IsCollatz(11541, out count));
            Console.WriteLine(IsCollatz(3116, out count));
            Console.WriteLine(LongestSequence());
        }

        public static int LongestSequence()
        {
            int maxCount = 0;
            int longest = -1;
            for (int n = 0; n <= 1000000; n++)
            {
                int count = 0;
                IsCollatz(n, out count);
                if (count > maxCount)
                {
                    longest = n;
                }
            }

            return longest;
        }

        public static bool IsCollatz(int n, out int count)
        {
            count = 0;
            while (n != 1)
            {
                if (n % 2 == 0)
                {
                    n = n / 2;
                }
                else
                {
                    n = 3 * n + 1;
                }
                count++;
            }

            return true;
        }
    }
}
