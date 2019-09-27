using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayExercises
{
    public class DuplicateCounter : IArrayTask
    {
        private const string ResultMessage = "Count of duplicate elements: ";

        public string Run()
        {
            int[] arr = Program.CreateArray();
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

            return ResultMessage + duplicates.Count;
        }
    }
}
