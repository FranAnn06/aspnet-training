using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
       public static string [] SortStringArray(string[] array)
        {
            if (array.Length < 2) 
            { 
                return array; 
            }
            int p = array[0].Length;

            return SortStringArray(array.Where(x => x.Length < p).ToArray()).Concat(array.Where(x => x.Length == p)).Concat(SortStringArray(array.Where(x => x.Length > p).ToArray())).ToArray();
        }
        ////return Array.Empty<string>();
        ///// }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку через пробел: ");
            foreach (string s in SortStringArray(Console.ReadLine().Split().ToArray()))
            {
                Console.WriteLine(s);
            }
        }

        }
    }

