using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortingLibrary;

namespace SortingConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {5, 8, 1, 6, 3, 9, 2};
            var sorter = GetSortObject("Heap");
            sorter.PerformSort(arr);
        }

        static ISort<int> GetSortObject(string sortType)
        {
            switch (sortType)
            {
                case "Heap":
                    return new HeapSort<int>();
                default:
                    return null;
            }
        }
    }
}
