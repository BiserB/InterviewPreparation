using System;

namespace ArrayExercises
{
    class Program
    {        
        static void Main(string[] args)
        {
            Console.WriteLine("Started...");
            
            /*** Uncomment some of the following lines to run specific task ***/
            // IArrayTask currentTask = new ReversePrinter();
            // IArrayTask currentTask = new AllElementsAccumulator();
            // IArrayTask currentTask = new ArrayDuplicator();
            // IArrayTask currentTask = new DuplicateCounter();
            // IArrayTask currentTask = new UniquePrinter();
            // IArrayTask currentTask = new ArrayMerger();
            // IArrayTask currentTask = new ArrayMergerII();
            // IArrayTask currentTask = new ArrayMergerIII();
            // IArrayTask currentTask = new FrequencyCounter();
            // IArrayTask currentTask = new MinMaxFinder();
            // IArrayTask currentTask = new OddEvenSeparator();
            // IArrayTask currentTask = new ValueInserter();
            // IArrayTask currentTask = new ElementEraser();
             IArrayTask currentTask = new SecondLargest();
            
            string result = currentTask.Run();

            Console.WriteLine(result);

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        public static int GetValue()
        {
            Console.WriteLine("Enter value to be inserted: ");

            return int.Parse(Console.ReadLine());
        }

        public static int GetPosition()
        {
            Console.WriteLine("Enter position to be deleted: ");

            return int.Parse(Console.ReadLine());
        }

        public static int[] CreateArray()
        {
            Console.WriteLine("Enter size of array:");

            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            Console.WriteLine("Enter every element on new line:");

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            return arr;
        }
    }
}
