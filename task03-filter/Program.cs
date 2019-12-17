using System;
using System.Linq;

namespace task03_filter
{
        class Program
        {
            static int[] Filter(int[] source)
            {
                int[] result = source.Distinct().ToArray();
                Console.WriteLine("Array without repeating elements: ");
                Console.WriteLine(string.Join(",", result));
                return Array.Empty<int>();
            }

            static void Main()
            {
                Console.WriteLine("Enter the size of the array: ");
                int n = Convert.ToInt32(Console.ReadLine());
                int[] source = new int[n];
                Random rand = new Random();

                for (int i = 0; i < source.Length; i++)
                {
                    source[i] = rand.Next(10);
                    Console.WriteLine(" " + source[i]);
                }
                Filter(source);
            }
        }
    }

