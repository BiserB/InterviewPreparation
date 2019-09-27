using System;

namespace ArrayExercises
{
    // Write a program in C# Sharp to find maximum and minimum element in an array.

    public class MinMaxFinder : IArrayTask
    {
        private const string ResultMessage = "Minimum and maximum elements in the array: ";

        public string Run()
        {
            int[] arr = Program.CreateArray();
            int min = int.MaxValue;
            int max = int.MinValue;

            foreach (var element in arr)
            {
                if (element < min)
                {
                    min = element;
                }

                if (element > max)
                {
                    max = element;
                }
            }

            return $"{ResultMessage} min = {min}, max = {max}";
        }
    }
}
