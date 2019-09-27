using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayExercises
{
    // Write a program to read n number of values in an array and display it in reverse order.

    public class ReversePrinter : IArrayTask
    {
        private const string ResultMessage = "The elements of the array in reverse order: ";

        public string Run()
        {
            int[] arr = Program.CreateArray();

            StringBuilder sb = new StringBuilder();
            sb.AppendLine(ResultMessage);

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (i > 0)
                {
                    sb.Append($"{arr[i]}, ");
                }
                else
                {
                    sb.Append(arr[i]);
                }
            }

            return sb.ToString();
        }

    }
}
