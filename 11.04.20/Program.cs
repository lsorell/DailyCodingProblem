using System;

namespace _11._04._20
{
    class Program
    {
        // You are given n numbers as well as n probabilities that sum up to 1. 
        // Write a function to generate one of the numbers with its corresponding probability.
        static void Main(string[] args)
        {
            int[] numbers = new int[4] {1, 2, 3, 4};
            double[] probabilities = new double[4] {0.1, 0.5, 0.2, 0.2};

            Console.WriteLine(WeightedRandomNumber(numbers, probabilities));
        }

        public static int WeightedRandomNumber(int[] numbers, double[] probabilities)
        {
            double rnd = new Random().NextDouble();

            for(int i = 0; i < numbers.Length; i++)
            {
                rnd -= probabilities[i];
                if(rnd < 0)
                {
                    return numbers[i];
                }
            }

            return -1;
        }
    }
}
