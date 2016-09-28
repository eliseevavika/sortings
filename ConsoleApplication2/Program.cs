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
            Console.WriteLine("Enter array size:");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];

            Console.WriteLine("Enter max element:");
            int maxElement = Convert.ToInt32(Console.ReadLine());

            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(maxElement);
            }

            WriteToConsole(array);
            Console.WriteLine("Enter sort method (0 or 1-5):");
            int sortMetod = Convert.ToInt32(Console.ReadLine());


          

            switch (sortMetod)
            {
                case 0:
                    BubbleSort.Sort(array);
                    ShellSort.Sort(array);
                    QuickSort.Sort(array);
                    SelectionSort.Sort(array);
                    InsertionSort.Sort(array);


                    break;
                case 1:
                    BubbleSort.Sort(array);

                    break;
                case 2:
                    ShellSort.Sort(array);
                    break;
                case 3:
                    QuickSort.Sort(array);
                    break;
                case 4:
                    SelectionSort.Sort(array);
                    break;
              case 5:
                    InsertionSort.Sort(array);
                     break;
                default:
                    Console.WriteLine("Method of number " + sortMetod + " is absent");
                    break;
            }
            WriteToConsole(array);
            Console.ReadLine();
        }
        private static void WriteToConsole(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine(" ");
        }


    }
}




