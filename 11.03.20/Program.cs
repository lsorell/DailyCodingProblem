using System;

namespace _11._03._20
{
    class Program
    {
        // Given a 2-D matrix representing an image, a location of a pixel in the screen and a color C, replace the color of the given pixel and all adjacent same colored pixels with C.
        static void Main(string[] args)
        {
            char[,] image = new char[,] {
                {'B', 'B', 'W'},
                {'W', 'W', 'W'},
                {'W', 'W', 'W'},
                {'B', 'B', 'B'}
            };

            char[,] result = ReplaceAdjacentPixels(image, new Tuple<int, int>(2, 2), 'G');
            
            for(int i = 0; i < result.GetLength(0); i++)
            {
                for(int j = 0; j < result.GetLength(1); j++)
                {
                    Console.Write(result[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static char[,] ReplaceAdjacentPixels(char[,] image, Tuple<int, int> pixel, char color)
        {
            char target = image[pixel.Item1, pixel.Item2];
        }

        public static char[,] ReplaceAdjacentPixelsRecusive(char[,] image, Tuple<int, int> pixel, char color, char target)
        {
            if(!IsAdjacentTarget)
            {
                return image;
            }
        }

        public static bool IsAdjacentTarget(char[,] image, Tuple<int, int> pixel, char target)
        {            
            int row = pixel.Item1;
            int col = pixel.Item2;
            if(row == 0)
            {
                //top left
                if(col == 0)
                {
                    return image[0, 1] == target || image[1, 0] == target;
                }
                //top right
                else if(col == image.GetLength(1))
                {
                    return image[0, col - 1] == target || image[1, col] == target;
                }
                //top
                return image[0, col - 1] == target || image[0, col + 1] == target || image[1, col] == target;
            }
            else if(row == image.GetLength(0))
            {
                //bottom left
                if(col == 0)
                {
                    return image[row - 1, 0] == target || image[row, col + 1] == target;
                }
                //bottom right
                else if(col == image.GetLength(1))
                {
                    return image[row, col - 1] == target || image[row - 1, col] == target;
                }
                //bottom
                return image[0, col - 1] == target || image[0, col + 1] == target || image[row - 1, col] == target;
            }
            //left
            else if(col == 0)
            {
                return image[row + 1, col] == target || image[row - 1, col] == target || image[row, col + 1] == target;
            }
            //right
            else if(col == image.GetLength(1))
            {
                return image[row + 1, col] == target || image[row - 1, col] == target || image[row, col - 1] == target;
            }
            //middle
            return image[row - 1, col] == target || image[row + 1, col] == target || image[row, col - 1] == target || image[row, col + 1] == target;
        }
    }
}
