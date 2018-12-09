using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsDataStructures.Sorts
{
    class Quick
    {
        public int[] Sort(int[] arrayOfNumbers, int low, int high)
        {
            if (low < high)
            {
                /* pi is partitioning index, arr[p] is now
                   at right place */
                int pi = partition(arrayOfNumbers, low, high);

                // Separately sort elements before
                // partition and after partition
                Sort(arrayOfNumbers, low, pi - 1);
                Sort(arrayOfNumbers, pi + 1, high);
            }
            return arrayOfNumbers;
        }
        int partition(int[] arrayOfNumbers, int low, int high)
        {
            int pivot = arrayOfNumbers[high];    // pivot
            int i = (low - 1);  // Index of smaller element

            for (int j = low; j <= high - 1; j++)
            {
                // If current element is smaller than or
                // equal to pivot
                if (arrayOfNumbers[j] <= pivot)
                {
                    i++;    // increment index of smaller element
                    Common.SwapElements(ref arrayOfNumbers[i], ref arrayOfNumbers[j]);
                }
            }
            Common.SwapElements(ref arrayOfNumbers[i + 1], ref arrayOfNumbers[high]);
            return (i + 1);
        }
    }
}
