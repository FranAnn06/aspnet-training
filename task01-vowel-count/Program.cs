using System;

namespace task01_vowel_count
{
    class Program
    {
        static int CountVowels(string s)
        {
            int k = 0;
            string g = "aeiou";
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < g.Length; j++)
                {
                    if (s[i] == g[j])
                    {
                        k++;
                    }
                }
            }
            Console.WriteLine("Number of vowels per line: ");
            return (k);

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string: ");
            string s = "";
            s = Console.ReadLine();

            if (!string.IsNullOrEmpty(s))
            {
                Console.WriteLine(CountVowels(s));
            }
            else Console.WriteLine("ArgumentNullException ");

        }
    }
}