using System;

namespace task05_prime_numbers
{
    class Program
    {
        static int[] GetPrimeNumbers(int start, int end)
        {
            int[] mas = new int[10];
            Random rand = new Random();
            mas[0] = start;
            mas[9] = end;
            for (int i = 1; i < 9; i++)
            {
                mas[i] = rand.Next(start, end);
            }
            Console.WriteLine("Array: ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(mas[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Sorted array: ");
            int minn = 0;
            for (int i = 0; i < 9; i++)
            {
                for (int j = i + 1; j < 10; j++)
                {
                    if (mas[i] > mas[j])
                    {
                        minn = mas[i];
                        mas[i] = mas[j];
                        mas[j] = minn;
                    }
                }

            }

            for (int i = 0; i < 10; i++)
            {
                Console.Write(mas[i] + " ");
            }


            return Array.Empty<int>();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter start ");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter end ");
            int end = Convert.ToInt32(Console.ReadLine());
            GetPrimeNumbers(start, end);


        }
    }
}

