using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication2;
using System.Diagnostics;

namespace ConsoleApplication2
{
    public class BubbleSort 
    {
       
        public static int[] Sort(int[] array)
        {
            int count = 0;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    count++;
                    if (array[j] > array[j + 1])
                    {
                        int k = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = k;
                        
                    }
                }
            }

            stopwatch.Stop();
            Console.WriteLine("BubbleSort");

            Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);
            Console.WriteLine("Counts of iterations:" + count);

            return array;

        }
    }
}

