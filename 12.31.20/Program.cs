using System;

namespace _12._31._20
{
    class Program
    {
        // Given an integer, find the next permutation of it in absolute order. For example, given 48975, the next permutation would be 49578.
        static void Main(string[] args)
        {
            Console.WriteLine(FindNextPerm(218765));
            Console.WriteLine(FindNextPerm(1234));
            Console.WriteLine(FindNextPerm(4321));
            Console.WriteLine(FindNextPerm(534976));
            Console.WriteLine(FindNextPerm(44234));
            Console.WriteLine(FindNextPerm(4828586));
        }

        public static int FindNextPerm(int num)
        {
            char[] numbers = num.ToString().ToCharArray();

            // check if numbers are in dec order
            bool dec = true;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (!(numbers[i] >= numbers[i + 1]))
                {
                    dec = false;
                    break;
                }
            }

            if (dec)
            {
                return num;
            }

            // check if numbers are asc order
            bool asc = true;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] <= numbers[i + 1])
                {
                    asc = false;
                    break;
                }

            }

            if (asc)
            {
                Swap(ref numbers, numbers.Length - 2, numbers.Length - 1);
                return Convert.ToInt32(new string(numbers));
            }

            // any other case
            int firstLessIndex = -1;
            for (int i = numbers.Length - 1; i > 0; i--)
            {
                if (numbers[i] > numbers[i - 1])
                {
                    firstLessIndex = i - 1;
                    break;
                }
            }
            int secondLessIndex = -1;
            int min = 10;
            for (int i = firstLessIndex + 1; i < numbers.Length; i++)
            {
                int n = (int)Char.GetNumericValue(numbers[i]);
                if (n < min)
                {
                    secondLessIndex = i;
                    min = n;
                }
            }
            Swap(ref numbers, firstLessIndex, secondLessIndex);
            firstLessIndex++;
            Array.Sort(numbers, firstLessIndex, numbers.Length - firstLessIndex);
            return Convert.ToInt32(new string(numbers));
        }

        public static void Swap(ref char[] input, int i, int j)
        {
            char temp = input[i];
            input[i] = input[j];
            input[j] = temp;
        }
    }
}
