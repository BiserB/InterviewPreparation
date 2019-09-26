using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayExercises
{
    interface IArrayTask
    {
        string Message { get; }

        void Run(int[] arr);
    }
}
