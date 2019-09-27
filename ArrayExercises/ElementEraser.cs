using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayExercises
{
    // Write a program in C# Sharp to delete an element at desired position from an array.

    public class ElementEraser : IArrayTask
    {
        private const string ResultMessage = "The array after deletition: ";

        public string Run()
        {
            int[] arr = Program.CreateArray();
            int position = Program.GetPosition();

            if (position <= 0 || position >= arr.Length)
            {
                return "Invalid position!";
            }

            int[] result = new int[arr.Length - 1];

            Array.Copy(arr, result, position - 1);
            Array.Copy(arr, position, result, position - 1, result.Length - position + 1);

            return ResultMessage + String.Join(", ", result);
        }
    }
}
