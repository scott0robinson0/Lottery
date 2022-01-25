using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotteryClasses
{
    public static class Utilities
    {
        public static int[] SortLowestToHighest(this int[] array)
        {
            bool sorted;
            int temp;
            do
            {
                sorted = true;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        sorted = false;
                        temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                    }
                }
            }
            while (!sorted);
            return array;
        }

        public static int[] SortHighestToLowest(this int[] array)
        {
            bool sorted;
            int temp;
            do
            {
                sorted = true;
                for (int i = array.Length - 1; i > 0; i--)
                {
                    if (array[i] > array[i - 1])
                    {
                        sorted = false;
                        temp = array[i];
                        array[i] = array[i - 1];
                        array[i - 1] = temp;
                    }
                }
            }
            while (!sorted);
            return array;
        }
    }
}
