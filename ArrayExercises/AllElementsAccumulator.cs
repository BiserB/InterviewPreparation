using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArrayExercises
{
    // Write a program in C# Sharp to find the sum of the all elements of the array.    

    public class AllElementsAccumulator: IArrayTask
    {
        public string ResultMessage => "The sum of the array elements:";
        
        public void Run(int[] arr)
        {
            long result = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                result += arr[i];
            }

            Console.WriteLine(result);
        }
    }
}
