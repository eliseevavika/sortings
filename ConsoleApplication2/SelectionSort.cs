using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApplication2
{
    class SelectionSort
    {
        public static int[] Sort (int[] array)
        {
            int count = 0;
            int min, temp;
            int length = array.Length;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < length - 1; i++)
            {
               
                min = i;

                for (int j = i + 1; j < length; j++)
                {
                    count++;
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }

                if (min != i)
                {
                    temp = array[i];
                    array[i] = array[min];
                    array[min] = temp;
                }
            }
            stopwatch.Stop();
            Console.WriteLine("***SelectionSort***");
            Console.WriteLine("Counts of iterations:" + count);
            Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);
            Console.WriteLine();

            return array;
        }
    }
}
