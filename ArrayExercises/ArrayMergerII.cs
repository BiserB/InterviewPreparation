using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayExercises
{
    // Write a program in C# Sharp to merge two arrays of same size sorted in ascending order.

    public class ArrayMergerII : IArrayTask
    {
        private const string ResultMessage = "The merged array in ascending order: ";

        public string Run()
        {
            int[] arr = Program.CreateArray();
            int[] arr2 = Program.CreateArray();

            List<int> merged = new List<int>(arr);

            merged.AddRange(arr2);

            merged.Sort();

            return ResultMessage + String.Join(", ", merged);
        }
    }
}
