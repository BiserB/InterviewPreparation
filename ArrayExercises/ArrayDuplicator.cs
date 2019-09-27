using System;


namespace ArrayExercises
{
    // Write a program in C# Sharp to copy the elements from one array into another array.

    public class ArrayDuplicator : IArrayTask
    {
        private const string ResultMessage = "The elements of the new array: ";

        public string Run()
        {
            int[] arr = Program.CreateArray();

            int[] arrCopy = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                arrCopy[i] = arr[i];
            }
            
            return ResultMessage + String.Join(", ", arrCopy);
        }
    }
}
