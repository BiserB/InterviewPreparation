using System;

namespace ArrayExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Started...");

            // IArrayTask currentTask = new ReversePrinter();
            // IArrayTask currentTask = new AllElementsAccumulator();
            // IArrayTask currentTask = new ArrayDuplicator();
            // IArrayTask currentTask = new DuplicateCounter();
            // IArrayTask currentTask = new UniquePrinter();
            // ArrayMerger currentTask = new ArrayMerger();
            // ArrayMergerII currentTask = new ArrayMergerII();
             ArrayMergerIII currentTask = new ArrayMergerIII();
            // IArrayTask currentTask = new FrequencyCounter();

            int[] arr = CreateArray();
            int[] arr2 = CreateArray();

            Console.WriteLine(currentTask.ResultMessage);

            currentTask.Run(arr, arr2);

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        static int[] CreateArray()
        {
            Console.WriteLine("Enter number of array elements:");

            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            Console.WriteLine("Elements on new line:");

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            return arr;
        }
    }
}
