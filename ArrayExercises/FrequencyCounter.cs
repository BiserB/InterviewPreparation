using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArrayExercises
{
    public class FrequencyCounter : IArrayTask
    {
        public string ResultMessage => "Frequency of each element of the array:";

        public void Run(int[] arr)
        {
            Dictionary<int, int> frequencies = new Dictionary<int, int>();

            foreach (var element in arr)
            {
                if (!frequencies.ContainsKey(element))
                {
                    frequencies[element] = 0;
                }

                frequencies[element]++;
            }

            // align all keys and values with adding indent
            int maxLength = frequencies.Keys.Max(k => k).ToString().Length;
            string[] keys = frequencies.Keys.Select(k => k.ToString().PadLeft(maxLength)).ToArray();
            string[] values = frequencies.Values.Select(k => k.ToString().PadLeft(maxLength)).ToArray();

            Console.WriteLine(String.Join(", ", keys));
            Console.WriteLine(String.Join(", ", values));
        }
    }
}
