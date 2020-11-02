using System;

namespace _11._02._20
{
    class Program
    {

        // Given a list of points, a central point, and an integer k, find the nearest k points from the central point.

        // For example, given the list of points [(0, 0), (5, 4), (3, 1)], the central point (1, 2), and k = 2, return [(0, 0), (3, 1)].
        static void Main(string[] args)
        {
            int[][] points = new int[3][];
            points[0] = new int[2] {0, 0};
            points[1] = new int[2] {5, 4};
            points[2] = new int[2] {3, 1};

            int[] centralPoint = new int[2] {1, 2};

            int k = 2;

            foreach(int[] arr in NearestPoints(points, centralPoint, k))
            {
                Console.WriteLine("{0}, {1}", arr[0], arr[1]);
            }            
        }

        public static int[][] NearestPoints(int[][] points, int[] centralPoint, int k)
        {
            int size = points.Length;
            int[][] closest = new int[k][];
            double[] distance = new double[size];
            
            for(int i = 0; i < size; i++)
            {
                distance[i] = Math.Sqrt(Math.Pow(points[i][0] - centralPoint[0], 2) + Math.Pow(points[i][1] - centralPoint[1], 2));
            }

            double[] distCopy = new double[size];
            Array.Copy(distance, distCopy, size);
            Array.Sort(distCopy);

            int j = 0;
            for(int i = 0; i < size; i++)
            {
                if(Array.BinarySearch(distCopy, 0, k, distance[i]) > -1)
                {
                    closest[j] = points[i];
                    j++;
                }
            }

            return closest;
        }
    }
}
