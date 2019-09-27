using System;
using System.Collections.Generic;

namespace ArrayExercises
{
    public class ArrayMergerIII
    {
        public string ResultMessage => "The merged array in ascending order:";

        public void Run(int[] arr, int[] arr2)
        {
            int[] merged = new int[arr.Length + arr2.Length];

            Array.Copy(arr, merged, arr.Length);

            Array.Copy(arr2, 0, merged, arr.Length, arr2.Length);

            ArraySorter.Sort(merged);

            Console.WriteLine(String.Join(", ", merged));
        }
    }
}