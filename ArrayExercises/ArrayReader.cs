using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayExercises
{
    public class ArrayReader
    {
        public static int[] GetArray()
        {
            Console.WriteLine("Enter the number of elements to store in the array:");

            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            return arr;
        }
    }
}
