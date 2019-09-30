using System;

namespace SetsFromArray
{
    // Print all different multisets (set with duplicate elements) 
    // containing K elements from a source integer set with N elements 
    // where 1 <= K <= N; K <= 5; N <= 25.
    // Example: Inputs: {1, 2, 3}, N = 3, K = 2
    // Output: (1, 1), (1, 2), (1, 3), (2, 2), (2, 3), (3, 3)

    class Program
    {
        private static string[] source;
        private static int setSize;
        private static string[] set;

        static void Main()
        {
            Console.WriteLine("Enter set size:");
            setSize = int.Parse(Console.ReadLine());

            set = new string[setSize];

            Console.WriteLine("Enter space separated elements:");
            source = Console.ReadLine().Split();

            Generate(0, 0);
        }

        static void Generate(int sourceIndex, int setIndex)
        {
            for (int i = sourceIndex; i < source.Length; i++)
            {
                set[setIndex] = source[i];

                if (setIndex + 1 < setSize)
                {
                    Generate(i, setIndex + 1);
                }
                else
                {
                    Console.WriteLine(string.Join(",", set));
                }
            }
        }
    }
}
