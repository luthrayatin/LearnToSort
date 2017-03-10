using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingLibrary
{
    public class HeapSort<T> : ISort<T> where T : struct, IComparable<T>
    {
        public T[] PerformSort(T[] input)
        {
            throw new NotImplementedException();
        }

        private static void Heapify(T[] input)
        {

        }

        private static void AdjustHeap(T[] input, int iParent)
        {
            var parent = input[iParent];
            int iLeftChild = iParent * 2 + 1, iRightChild = iParent * 2 + 2;
            if (iLeftChild >= input.Length) return;
            if (iRightChild < input.Length && input[iParent].CompareTo(input[iRightChild]) < 0)
            {
                if (input[iRightChild].CompareTo(input[iLeftChild]) > 0)
                {
                    input[iParent] = input[iRightChild];
                    input[iRightChild] = parent;
                    AdjustHeap(input, iRightChild);
                }
                else
                {
                    input[iParent] = input[iLeftChild];
                    input[iLeftChild] = parent;
                    AdjustHeap(input, iLeftChild);
                }
            }
            else if (input[iParent].CompareTo(input[iLeftChild]) < 0)
            {
                input[iParent] = input[iLeftChild];
                input[iLeftChild] = parent;
                AdjustHeap(input, iLeftChild);
            }
        }
    }
}
