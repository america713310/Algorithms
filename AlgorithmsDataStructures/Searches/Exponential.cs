using AlgorithmsDataStructures.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsDataStructures.Searches
{
    class Exponential : ISearch
    {
        public int Search(int[] array, int arrayOfNumbers)
        {
            if (array[0] == arrayOfNumbers)
                return 0;

            int i = 1;
            while (i < array.Length && array[i] <= arrayOfNumbers)
                i = i * 2;

            return BinarySearch(array, i / 2, Math.Min(i, array.Length), arrayOfNumbers);
        }

        public int Search(int[] array, int start, int end)
        {
            throw new NotImplementedException();
        }

        int BinarySearch(int[] array, int start, int end, int arrayOfNumbers)
        {
            if (end >= start)
            {
                int mid = start + (end - start) / 2;

                if (array[mid] == arrayOfNumbers)
                    return mid;
                if (array[mid] > arrayOfNumbers)
                    return BinarySearch(array, start, mid - 1, arrayOfNumbers);
                return BinarySearch(array, mid + 1, end, arrayOfNumbers);
            }
            return -1;
        }
    }
}
