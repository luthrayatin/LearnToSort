using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingConsole
{
    class WriteArrayToConsole<T> : IDataWriter<T> where T : struct, IComparable<T>
    {
        public void WriteString(string text)
        {
            Console.WriteLine(text);
        }

        public void WriteData(T[] input)
        {
            foreach (T dataItem in input)
            {
                Console.Write($"{dataItem} ");
            }
        }
    }
}
