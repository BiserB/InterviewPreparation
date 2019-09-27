using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayExercises
{
    // Write a program in C# Sharp to sort elements of array in ascending order.
    // Write a program in C# Sharp to sort elements of the array in descending order.

    public class ArraySorter
    {
        public static int[] SortAsc(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    int current = arr[j];
                    int next = arr[j + 1];

                    if (current > next)
                    {
                        arr[j] = next;
                        arr[j + 1] = current;
                    }
                }
            }

            return arr;
        }

        public static int[] SortDesc(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    int current = arr[j];
                    int next = arr[j + 1];

                    if (current < next)
                    {
                        arr[j] = next;
                        arr[j + 1] = current;
                    }
                }
            }

            return arr;
        }
    }
}
