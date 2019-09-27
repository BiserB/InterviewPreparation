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
                return "Too small array";
            }

            int[] maxElements = new int[] { arr[0], arr[1] };

            
            return ResultMessage;
        }
    }
}
