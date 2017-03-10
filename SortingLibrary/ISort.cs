using System;
using System.Collections;
using System.Collections.Generic;

namespace SortingLibrary
{
    public interface ISort<T> where T : struct, IComparable<T>
    {
        T[] PerformSort(T[] inputArray);
    }
}