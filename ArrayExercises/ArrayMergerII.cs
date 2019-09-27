using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayExercises
{
    // Write a program in C# Sharp to merge two arrays of same size sorted in ascending order.

    public class ArrayMergerII
    {
        public string ResultMessage => "The merged array in ascending order:";

        public void Run(int[] arr, int[] arr2)
        {
            List<int> merged = new List<int>(arr);

            merged.AddRange(arr2);

            merged.Sort();

            Console.WriteLine(String.Join(", ", merged));
        }
    }
}
