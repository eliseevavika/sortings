using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace ConsoleApplication2
{
    class InsertionSort
    {
        public static int[] Sort(int[] array)
        {
            int count = 0;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 1; i < array.Length; i++)
            {
                count++;
                int cur = array[i];
                int j = i;
                while (j > 0 && cur < array[j - 1])
                {
                    array[j] = array[j - 1];
                    j--;
                }
                array[j] = cur;
            }

            stopwatch.Stop();
            Console.WriteLine("InsertionSort");

            Console.WriteLine("Counts of iterations:" + count);
            Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);

            return array;

        }
    }
}

