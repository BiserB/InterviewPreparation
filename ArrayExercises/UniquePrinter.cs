using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayExercises
{
    // Write a program in C# Sharp to print all unique elements in an array

    public class UniquePrinter : IArrayTask
    {
        private const string ResultMessage = "The all unique elements in the array: ";

        public string Run()
        {
            int[] arr = Program.CreateArray();

            List<int> duplicates = new List<int>();
            List<int> uniques = new List<int>();
            
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int current = arr[i];

                for (int j = i + 1; j < arr.Length; j++)
                {
                    int next = arr[j];

                    if (duplicates.Contains(current))
                    {
                        break;
                    }

                    if (next == current)
                    {
                        duplicates.Add(current);
                        break;
                    }
                }
            }

            foreach (var element in arr)
            {
                if (!duplicates.Contains(element))
                {
                    uniques.Add(element);
                }
            }

            return ResultMessage + String.Join(", ", uniques);
        }
    }
}
