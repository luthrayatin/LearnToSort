using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using SortingLibrary;

namespace SortingConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Setup autofac configuration.
            var builder = new ContainerBuilder();
            builder.RegisterType<WriteArrayToConsole<int>>().As<IDataWriter<int>>().InstancePerLifetimeScope();
            var container = builder.Build();

            int[] arr = {5, 8, 1, 6, 3, 9, 2};
            var sorter = GetSortObject("Heap");
            sorter.PerformSort(arr);

            using (var scope = container.BeginLifetimeScope())
            {
                var dataWriter = scope.Resolve<IDataWriter<int>>();
                dataWriter.WriteString("Sorted Array:");
                dataWriter.WriteData(arr);
            }
        }

        static ISort<int> GetSortObject(string sortType)
        {
            switch (sortType)
            {
                case "Heap":
                    return new HeapSort<int>();
                case "Merge":
                    return new MergeSort<int>();
                default:
                    return null;
            }
        }
    }
}
