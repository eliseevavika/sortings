using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication2;



namespace ConsoleApplication2
{
    public class Program
    {

        static void Main(string[] args)
        {
            //string entry1= "BubbleSorting";
            int Bubble = 0;
            int n;
            Console.WriteLine("Введите размер массива:");
            n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            for (int m = 0; m < array.Length; m++)
            {
                Console.WriteLine("Введите элементы массива:" + array[m]);
                Console.ReadLine();
                Console.WriteLine("Размер массива составляет:" + n);
            }
            Console.WriteLine("Укажите метод сортировки:");
            string entry1 = Console.ReadLine();
            if (entry1 == "Bubble")
            {
                //вывести метод BubbleSort
                Program bubble = new Program();
                bubble.BubbleSort();

            }
        }

        private void BubbleSort()
        {
            throw new NotImplementedException();
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            int k;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        k = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = k;

                        Console.WriteLine("");

                    }
                }
            }
        }

        private void ShellSort()
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            int d;
            int i;
            for (i = 0; i < array.Length; i++)
            {
                d = n / 2;
                if (array[i] > array[i + d])
                {
                    int f = array[i];
                    array[i] = array[i + d];
                    array[i + d] = f;
                }
            }

            d = n / 4;



            d = n / 2;


            //  !!!
            d = n;
        }
        private void QuickSort()
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            int central = array[n / 2];
            int[] left = new int[n / 2 + 1];
            int[] rihgt = new int[n / 2 - 1];
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = (n / 2 + 1 + i); j < array.Length; j++)
                    if (left[i] >= central && rihgt[j] <= central)
                    {
                        int z = left[i];
                        left[i] = rihgt[j];
                        rihgt[j] = z;
                    }
                    else if (left[i] >= central || rihgt[j] <= central)
                    {
                        //непонятно как записывать значение элемента, менять с каким-то или отельное место как-то задавать
                    }
            } }

        private void EvenOddSort()
        {
        
            int t=1;
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];

            for (int i = 0; i < array.Length; i=+2)
            {
                for (int j = i+1; j < array.Length; j++)
                {
               
                    if (array[j] > array[j + 1])
                    {
                        int w = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = w;
                    }
                   
            

            
                }
            }
        }

    }


}




