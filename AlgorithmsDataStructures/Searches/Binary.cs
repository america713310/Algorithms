using AlgorithmsDataStructures.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsDataStructures.Searches
{
    class Binary : ISearch
    {
        public int Search(int[] arrayOfNumbers, int start, int end)
        {
            int key = 7;
            int _middle = 0;

            while (start <= end)
            {
                _middle = (start + end) / 2;
                if (arrayOfNumbers[_middle] < key)
                {
                    start = _middle + 1;
                }
                else if (arrayOfNumbers[_middle] > key)
                {
                    end = _middle - 1;
                }
                else
                {
                    return _middle;
                }
            }
            return -1;
        }

        public int Search(int[] arrayOfNumbers, int element)
        {
            throw new NotImplementedException();
        }
    }
}
