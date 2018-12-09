using AlgorithmsDataStructures.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsDataStructures.Sorts
{
    class Insertion : ISort
    {
        public void Sort(int[] arrayOfNumbers)
        {
            int _temp = 0, j = 0;

            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                _temp = arrayOfNumbers[i];
                j = i;
                while (j > 0 && _temp < arrayOfNumbers[j - 1])
                {
                    arrayOfNumbers[j] = arrayOfNumbers[j - 1];
                    j = j - 1;
                }
                arrayOfNumbers[j] = _temp;
            }

            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                Console.Write(arrayOfNumbers[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
