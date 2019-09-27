using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayExercises
{
    // Write a program in C# Sharp to insert New value in the sorted array.

    public class ValueInserter: IArrayTask
    {
        private const string ResultMessage = "The array with inserted value: ";

        public string Run()
        {
            int[] arr = Program.CreateArray();
            int value = Program.GetValue();

            int[] result = new int[arr.Length + 1];

            bool inserted = false;
            int index = 0;

            while (!inserted && index < arr.Length)
            {
                if (value > arr[index])
                {
                    result[index] = arr[index];
                }
                else
                {
                    result[index] = value;
                    result[index + 1] = arr[index];
                    inserted = true;
                }
                index++;
            }

            while (inserted && index < arr.Length)
            {
                result[index + 1] = arr[index];

                index++;
            }

            if (!inserted)
            {
                result[index] = value;
            }

            return ResultMessage + String.Join(", ", result);
        }        
    }

}
