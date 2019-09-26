using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayExercises
{
    interface IArrayTask
    {
        string ResultMessage { get; }

        void Run(int[] arr);
    }
}
