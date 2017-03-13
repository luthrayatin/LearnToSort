using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingConsole
{
    interface IDataWriter<T> where T: struct, IComparable<T>
    {
        void WriteString(string text);
        void WriteData(T[] input);
    }
}
