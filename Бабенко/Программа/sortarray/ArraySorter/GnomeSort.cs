﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Babenko_GnomeSort
{
    public class GnomeSorter
    {
        static void Swap(ref int item1, ref int item2)
        {
            var temp = item1;
            item1 = item2;
            item2 = temp;
        }

        //Гномья сортировка
        public static int[] SortArray(int[] unsortedArray)
        {
            var index = 1;
            var nextIndex = index + 1;

            while (index < unsortedArray.Length)
            {
                if (unsortedArray[index - 1] < unsortedArray[index])
                {
                    index = nextIndex;
                    nextIndex++;
                }
                else
                {
                    Swap(ref unsortedArray[index - 1], ref unsortedArray[index]);
                    index--;
                    if (index == 0)
                    {
                        index = nextIndex;
                        nextIndex++;
                    }
                }
            }

            return unsortedArray;
        }

    }
}
