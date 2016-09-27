using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class InsertionSort
    {
        public static int[] Sort(int[] array)
        {
            int count = 0;
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
            Console.WriteLine("Counts of iterations:" + count);

            return array;

        }
    }
}