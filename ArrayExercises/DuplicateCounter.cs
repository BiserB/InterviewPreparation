using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayExercises
{
    public class DuplicateCounter : IArrayTask
    {
        public string ResultMessage => "Count of duplicate elements:";

        public void Run(int[] arr)
        {
            List<int> duplicates = new List<int>();

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

                    if(next == current)
                    {
                        duplicates.Add(current);
                        break;
                    }
                }
            }

            Console.WriteLine(duplicates.Count);
        }
    }
}
