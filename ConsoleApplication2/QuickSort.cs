using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class QuickSort:Program
    {
        static int Partition(int[] array, int start, int end)
        {
            int count = 0;
            int marker = start;
            for (int i = start; i <= end; i++)
            {
                if (array[i] <= array[end])
                {
                    int temp = array[marker]; // swap
                    array[marker] = array[i];
                    array[i] = temp;
                    marker += 1;
                    count++;
                }
            }
            return marker - 1;
        }

        public static int[] Sort(int[] array)
        {
            Sort(array, 0, array.Length - 1);
            return array;
        }

        static void Sort(int[] array, int start, int end)
        {
            if (start >= end)
            {
                return;
            }
            int pivot = Partition(array, start, end);
            Sort(array, start, pivot - 1);
            Sort(array, pivot + 1, end);

        }
    }
}