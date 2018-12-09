using AlgorithmsDataStructures.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsDataStructures.Searches
{
    class Fibonacci : ISearch
    {
        public int Search(int[] arrayOfNumbers, int element)
        {
            int fibMMm2 = 0;
            int fibMMm1 = 1;
            int fibM = fibMMm2 + fibMMm1;

            while (fibM < arrayOfNumbers.Length)
            {
                fibMMm2 = fibMMm1;
                fibMMm1 = fibM;
                fibM = fibMMm2 + fibMMm1;
            }

            int offset = -1;

            while (fibM > 1)
            {
                int i = Math.Min(offset + fibMMm2, arrayOfNumbers.Length - 1);

                if (arrayOfNumbers[i] < element)
                {
                    fibM = fibMMm1;
                    fibMMm1 = fibMMm2;
                    fibMMm2 = fibM - fibMMm1;
                    offset = i;
                }

                else if (arrayOfNumbers[i] > element)
                {
                    fibM = fibMMm2;
                    fibMMm1 = fibMMm1 - fibMMm2;
                    fibMMm2 = fibM - fibMMm1;
                }

                else return i;
            }

            if (fibMMm1 == element && arrayOfNumbers[offset + 1] == element)
                return offset + 1;

            return -1;
        }

        public int Search(int[] arrayOfNumbers, int start, int end)
        {
            throw new NotImplementedException();
        }
    }
}
