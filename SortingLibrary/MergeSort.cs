using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingLibrary
{
    public class MergeSort<T> : ISort<T> where T : struct, IComparable<T>
    {
        public T[] PerformSort(T[] inputArray)
        {
            DivideAndMerge(inputArray, 0, inputArray.Length - 1);
            return inputArray;
        }

        private void DivideAndMerge(T[] inputArray, int iArrayStart, int iArrayEnd)
        {
            //Mark the breakpoint for dividing the specified section of the array into two almost half sized parts.
            int dividedLength = -1, breakPoint = -1;
            if (iArrayEnd <= iArrayStart) return;
            dividedLength = (iArrayEnd - iArrayStart + 1) / 2;
            breakPoint = iArrayStart + dividedLength % 2 == 0 ? dividedLength : dividedLength + 1;
            DivideAndMerge(inputArray, iArrayStart, breakPoint);
            DivideAndMerge(inputArray, breakPoint + 1, iArrayEnd);
            //Merge the arrays into one.
            for (int i = iArrayStart, j = breakPoint + 1; i <= breakPoint && j <= iArrayEnd;)
            {
                if (inputArray[i].CompareTo(inputArray[j]) > 0)
                {
                    
                }
            }
        }

        private void Divide(T[] inputArray, int iArrayStart, int iArrayEnd)
        {
            //Divide the array into two almost half sized arrays.
            int dividedLength = -1, breakPoint = -1;
            if (iArrayEnd <= iArrayStart) return;
            dividedLength = (iArrayEnd - iArrayStart + 1) / 2;
            breakPoint = iArrayStart + dividedLength % 2 == 0 ? dividedLength : dividedLength + 1;
        }
    }
}
