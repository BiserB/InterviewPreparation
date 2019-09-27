using System;
using System.Collections.Generic;

namespace ArrayExercises
{
    // Write a programin C# Sharp to separate odd and even integers in separate arrays.

    public class OddEvenSeparator : IArrayTask
    {
        private const string ResultMessage = "Odd and even integers in separate arrays: ";

        public string Run()
        {
            int[] arr = Program.CreateArray();
            List<int> oddNumbers = new List<int>();
            List<int> evenNumbers = new List<int>();

            foreach (var number in arr)
            {
                if (number % 2 == 0)
                {
                    if (!evenNumbers.Contains(number))
                    {
                        evenNumbers.Add(number);
                    }                    
                }
                else if(!oddNumbers.Contains(number))
                {
                    oddNumbers.Add(number);
                }
            }

            return $"{ResultMessage}{Environment.NewLine}" +
                    $"Odd numbers = { String.Join(", ", oddNumbers)}{Environment.NewLine}" +
                    $"Even numbers = {String.Join(", ", evenNumbers)}";
        }
    }
}
