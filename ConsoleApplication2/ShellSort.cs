using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApplication2
{
    public class ShellSort 
    {
        public static int[] Sort(int[] array)
        {
            int count = 0;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            int j;
            int step = array.Length / 2;
            while (step > 0)
            {
                for (int i = 0; i < (array.Length - step); i++)
                {
                    count++;
                    j = i;
                    while ((j >= 0) && (array[j] > array[j + step]))
                    {
                        int tmp = array[j];
                        array[j] = array[j + step];
                        array[j + step] = tmp;
                        j -= step;
                       
                    }
                }
                step = step / 2;
            }

            stopwatch.Stop();
            Console.WriteLine("ShellSort");

            Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);
            Console.WriteLine("Counts of iterations:" + count);

            return array;

        }

    }
}

