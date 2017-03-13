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
            var iEnd = input.Length - 1;
            //Let's just call Heapify.
            Heapify(input, iEnd);

            //Let's swap the root element with the last element recursively to get the final sorted array.
            while (iEnd > 0)
            {
                var rootVal = input[0];
                input[0] = input[iEnd];
                input[iEnd] = rootVal;
                iEnd--;
                Heapify(input, iEnd);
            }
            return input;
        }

        private static void Heapify(T[] input, int iEnd)
        {
            //Start by calling the AdjustHeap for the last parent in the input.
            var iCurrentParent = (int)Math.Ceiling((double)iEnd / 2 - 1);
            while (iCurrentParent >= 0)
            {
                AdjustHeap(input, iCurrentParent, iEnd);
                iCurrentParent--;
            }
        }

        private static void AdjustHeap(T[] input, int iParent, int iEnd)
        {
            var parent = input[iParent];
            int iLeftChild = iParent * 2 + 1, iRightChild = iParent * 2 + 2;
            if (iLeftChild > iEnd) return;
            if (iRightChild <= iEnd && input[iParent].CompareTo(input[iRightChild]) < 0)
            {
                if (input[iRightChild].CompareTo(input[iLeftChild]) > 0)
                {
                    input[iParent] = input[iRightChild];
                    input[iRightChild] = parent;
                    AdjustHeap(input, iRightChild, iEnd);
                }
                else
                {
                    input[iParent] = input[iLeftChild];
                    input[iLeftChild] = parent;
                    AdjustHeap(input, iLeftChild, iEnd);
                }
            }
            else if (input[iParent].CompareTo(input[iLeftChild]) < 0)
            {
                input[iParent] = input[iLeftChild];
                input[iLeftChild] = parent;
                AdjustHeap(input, iLeftChild, iEnd);
            }
        }
    }
}
