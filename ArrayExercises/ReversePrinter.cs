using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayExercises
{
    // Write a program to read n number of values in an array and display it in reverse order.

    public class ReversePrinter: IArrayTask
    {
        public string Message => "displays all the elements of the array in reverse order";
        
        public void Run(int[] arr)
        {
            int length = arr.Length;

            for (int i = length - 1; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
