using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort.Usage
{
    class Program
    {
        static void Main(string[] args)
        {
            InsertionSorter sorter = new InsertionSorter();
            Console.Write("Количество элементов в массиве: ");
            int a = int.Parse(Console.ReadLine());
            int[] Arr = new int[a];
            for (int j = 0; j < a; j++)
            {
                Console.Write("Элемент " + j + ":  ");
                Arr[j] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Массив после сортировки:");
            sorter.InsSort(Arr);
            for (int j = 0; j < a; j++)
                Console.Write(Arr[j] + " ");
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
