using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayExercises
{
    // Write a program in C# Sharp to find the second largest element in an array.

    public class SecondLargest : IArrayTask
    {
        private const string ResultMessage = "The second largest element in the array: ";

        public string Run()
        {
            int[] arr = Program.CreateArray();

            if (arr.Length < 2)
            {
                return "Array is too small!";
            }

            int second, first;

            if (arr[0] <= arr[1])
            {
                second = arr[0];
                first = arr[1];
            }
            else
            {
                second = arr[1];
                first = arr[0];
            }
            
            for (int i = 2; i < arr.Length; i++)
            {
                if (arr[i] > first)
                {
                    second = first;
                    first = arr[i];
                }
                else if(arr[i] > second)
                {
                    second = arr[i];
                }
            }
            
            return ResultMessage + second;
        }
    }

}
