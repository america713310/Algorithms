using AlgorithmsDataStructures.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsDataStructures.Sorts
{
    class Selection : ISort
    {
        public void Sort(int[] arrayOfNumbers)
        {
            int _minimum = 0;

            for (int i = 0; i < arrayOfNumbers.Length - 1; i++)
            {
                _minimum = i;
                for (int j = i + 1; j < arrayOfNumbers.Length; j++)
                {
                    if (arrayOfNumbers[j] < arrayOfNumbers[_minimum])
                        _minimum = j;
                }
                Common.SwapElements(ref arrayOfNumbers[i], ref arrayOfNumbers[_minimum]);
            }
            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                Console.Write(arrayOfNumbers[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
