using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsDataStructures.Sorts
{
    class Bubble
    {
        public void Sort(int[] arrayOfNumbers)
        {
            int j = 0;
            bool _swapped = true;

            while (_swapped)
            {
                _swapped = false;
                j++;
                for (int i = 0; i < arrayOfNumbers.Length - j; i++)
                {
                    if (arrayOfNumbers[i] > arrayOfNumbers[i + 1])
                    {
                        Common.SwapElements(ref arrayOfNumbers[i], ref arrayOfNumbers[i + 1]);
                        _swapped = true;
                    }
                }
            }
            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                Console.Write(arrayOfNumbers[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
