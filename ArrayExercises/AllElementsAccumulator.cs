using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArrayExercises
{
    // Write a program in C# Sharp to find the sum of the all elements of the array.    

    public class AllElementsAccumulator: IArrayTask
    {
        private const string ResultMessage = "The sum of the array elements: ";
        
        public string Run()
        {
            int[] arr = Program.CreateArray();

            long result = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                result += arr[i];
            }

            return ResultMessage + result;
        }
    }
}
