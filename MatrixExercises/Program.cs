using System;
using System.Collections.Generic;

namespace PrimeNumbersMatrix
{
    // Build matrix filled with prime numbers

    class Program
    {
        private static int[,] matrix;

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");

            int num = int.Parse(Console.ReadLine());

            List<int> primes = GetPrimes(num * num);

            BuildMatrix(num, primes);

            PrintMatrix();

            Console.ReadKey();
        }

        private static void BuildMatrix(int num, List<int> primes)
        {
            matrix = new int[num, num];
            int index = 0;

            for (int r = 0; r < num; r++)
            {
                for (int c = 0; c < num; c++)
                {
                    matrix[r, c] = primes[index++];
                }
            }
        }

        private static List<int> GetPrimes(int count)
        {
            List<int> primes = new List<int>(count);

            int candidate = 2;

            while (primes.Count < count)
            {
                if (IsPrime(candidate))
                {
                    primes.Add(candidate);
                }

                candidate++;
            }

            return primes;
        }

        private static bool IsPrime(int num)
        {
            var maxDivider = Math.Sqrt(num);

            for (int divider = 2; divider <= maxDivider; divider++)
            {
                if (num % divider == 0)
                {
                    return false;
                }
            }

            return true;
        }

        private static void PrintMatrix()
        {
            // align all numbers with adding indent

            int maxLength = 0;

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    int numberLength = matrix[r, c].ToString().Length;

                    if (numberLength > maxLength)
                    {
                        maxLength = numberLength;
                    }
                }
            }

            maxLength++; // extra space

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    Console.Write(matrix[r, c].ToString().PadLeft(maxLength));
                }

                Console.WriteLine();
            }
        }
    }
}
