using AlgorithmsDataStructures.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsDataStructures.Searches
{
    class Interpolation : ISearch
    {
        public int Search(int[] arrayOfNumbers, int element)
        {
            int lo = 0, hi = (arrayOfNumbers.Length - 1);
            int pos = 0;
            while (lo <= hi && element >= arrayOfNumbers[lo] && element <= arrayOfNumbers[hi])
            {
                if (arrayOfNumbers[hi] - arrayOfNumbers[lo] == 0)
                {
                    lo = pos + 1;
                    return lo;
                }
                else
                {
                    pos = lo + (((hi - lo) / (arrayOfNumbers[hi] - arrayOfNumbers[lo])) * (element - arrayOfNumbers[lo]));
                    if (arrayOfNumbers[pos] == element)
                        return pos;
                    if (arrayOfNumbers[pos] < element)
                        lo = pos + 1;
                    else
                        hi = pos - 1;
                }
            }
            return -1;
        }

        public int Search(int[] arrayOfNumbers, int start, int end)
        {
            throw new NotImplementedException();
        }
    }
}
