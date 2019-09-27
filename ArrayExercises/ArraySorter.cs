using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayExercises
{
    public class ArraySorter
    {
        public static int[] Sort(int[] arr)
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
    }
}
