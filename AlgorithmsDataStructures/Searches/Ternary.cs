using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsDataStructures.Searches
{
    class Ternary
    {
        public int Search(int start, int end, int element)
        {
            int[] _arrayOfNumbers = { 2, 3, 5, 6, 7, 8, 9, 10, 11 };

            if (end >= start)
            {
                int mid1 = start + (end - start) / 3;
                int mid2 = end - (end - start) / 3;
                if (_arrayOfNumbers[mid1] == element)
                    return mid1;
                if (_arrayOfNumbers[mid2] == element)
                    return mid2;
                if (element < _arrayOfNumbers[mid1])
                    return Search(start, mid1 - 1, element);
                else if (element > _arrayOfNumbers[mid2])
                    return Search(mid2 + 1, end, element);
                else
                    return Search(mid1 + 1, mid2 - 1, element);

            }
            return -1;
        }
    }
}
