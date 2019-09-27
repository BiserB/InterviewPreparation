using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArrayExercises
{
    // Write a program in C# Sharp to merge two arrays of same size sorted in ascending order.

    public class ArrayMerger : IArrayTask
    {
        private const string ResultMessage = "The merged array in ascending order:";

        public string Run()
        {
            int[] arr = Program.CreateArray();
            int[] arr2 = Program.CreateArray();

            int[] merged = new int[arr.Length + arr2.Length];

            Array.Copy(arr, merged, arr.Length);
            Array.Copy(arr2, 0, merged, arr.Length,arr2.Length);

            Array.Sort(merged);

            return ResultMessage + String.Join(",", merged);
        }

    }
}
