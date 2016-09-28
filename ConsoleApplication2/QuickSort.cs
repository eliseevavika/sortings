using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApplication2
{
    class QuickSort
    {
        static int count = 0;

        static int Partition(int[] array, int start, int end)
        {
            int marker = start;
            for (int i = start; i <= end; i++)
            {
                count++;

                if (array[i] <= array[end])
                {
                    int temp = array[marker]; 
                    array[marker] = array[i];
                    array[i] = temp;
                    marker += 1;

                }
            }
            
            return marker - 1;
        }

        public static int[] Sort(int[] array)
        { 
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            Sort(array, 0, array.Length - 1);

            stopwatch.Stop();
            Console.WriteLine("***QuickSort***");
            Console.WriteLine("Counts of iterations:" + count);
            Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);
            Console.WriteLine();

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