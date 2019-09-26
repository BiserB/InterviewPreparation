using System;

namespace ArrayExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            IArrayTask currentTask = new ReversePrinter();

            Console.WriteLine("Started...");
            Console.WriteLine($"Program which {currentTask.Message}.");

            int[] arr = CreateArray();

            currentTask.Run(arr);

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
