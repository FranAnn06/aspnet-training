using System;

namespace task04_find_min_max
{
    class Program
    {
        static bool FindMinMax(int[][] array, out int min, out int max)
        {
            min = array[0][0];
            max = array[0][0];
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    if (array[i][j] < min)
                    {
                        min = array[i][j];
                    }
                }

            }
            Console.WriteLine("Min element: " + min);
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    if (array[i][j] > max)
                    {
                        max = array[i][j];
                    }
                }

            }
            Console.WriteLine("Max element: " + max);
            return false;
        }
        static void Main(string[] args)
        {
            int[][] array = new int[2][];
            array[0] = new int[5] { 8, 4, 8, 3, 5 };
            array[1] = new int[7] { 6, 5, 8, 3, 4, 9, 1 };
            for (int i = 0; i < array.Length; i++)
            {

                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(" " + array[i][j]);

                }
                Console.WriteLine();
            }
            FindMinMax(array, out int min, out int max);
        }
    }
}
