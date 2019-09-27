using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArrayExercises
{
    // Write a program in C# Sharp to merge two arrays of same size sorted in ascending order.

    public class ArrayMerger
    {
        public string ResultMessage => "The merged array in ascending order:";

        public void Run(int[] arr, int[] arr2)
        {
            int[] merged = new int[arr.Length + arr2.Length];

            Array.Copy(arr, merged, arr.Length);
            Array.Copy(arr2, 0, merged, arr.Length,arr2.Length);

            Array.Sort(merged);

            Console.WriteLine(String.Join(",", merged));
        }

    }
}
