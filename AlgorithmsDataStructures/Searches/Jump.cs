using AlgorithmsDataStructures.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsDataStructures.Searches
{
    class Jump : ISearch
    {
        public int Search(int[] array, int element)
        {
            int _step = (int)Math.Pow(array.Length, 1 / 2);
            int _previous = 0;

            while (array[Math.Min(_step, array.Length) - 1] < element)
            {
                _previous = _step;
                _step += (int)Math.Pow(array.Length, 1 / 2);
                if (_previous >= array.Length)
                    return -1;
            }

            while (array[_previous] < element)
            {
                _previous++;

                if (_previous == Math.Min(_step, array.Length))
                    return -1;
            }
            if (array[_previous] == element)
                return _previous;

            return -1;
        }

        public int Search(int[] array, int start, int end)
        {
            throw new NotImplementedException();
        }
    }
}
