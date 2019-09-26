using System;


namespace ArrayExercises
{
    // Write a program in C# Sharp to copy the elements from one array into another array.

    class ArrayDuplicator : IArrayTask
    {
        public string ResultMessage => "The elements of new array:";

        public void Run(int[] arr)
        {
            int[] arrCopy = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                arrCopy[i] = arr[i];
            }
            
            Console.WriteLine(String.Join(", ", arrCopy));
        }
    }
}
