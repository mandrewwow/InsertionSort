using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    public class InsertionSorter
    {
      



    public void InsSort(int[] mass)
        {
            for (int i = 1; i < mass.Length; i++)
            {
                int cur = mass[i];
                int j = i;
                while (j > 0 && cur < mass[j - 1]) // пока j>0 и i-ый элемент меньше j-1 элемента
                {
                    mass[j] = mass[j - 1]; // меняем местами элементы j и j-1
                    j--;
                }
                mass[j] = cur; //меняем cur
            }
        }
    }
}