using System;
using System.Collections.Generic;

namespace ArrayExercises
{
    public class ArrayMergerIII : IArrayTask
    {
        private const string ResultMessage = "The merged array in ascending order: ";

        public string Run()
        {
            int[] arr = Program.CreateArray();
            int[] arr2 = Program.CreateArray();

            int[] merged = new int[arr.Length + arr2.Length];

            Array.Copy(arr, merged, arr.Length);

            Array.Copy(arr2, 0, merged, arr.Length, arr2.Length);

            ArraySorter.SortAsc(merged);

            return ResultMessage + String.Join(", ", merged);
        }
    }
}