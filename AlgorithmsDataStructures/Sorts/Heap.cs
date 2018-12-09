using AlgorithmsDataStructures.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsDataStructures.Sorts
{
    class Heap : ISort
    {
        public void Sort(int[] arrayOfNumbers)
        {
            for (int i = arrayOfNumbers.Length / 2 - 1; i >= 0; i--)
                Heapify(arrayOfNumbers, arrayOfNumbers.Length, i);

            for (int i = arrayOfNumbers.Length - 1; i >= 0; i--)
            {
                Common.SwapElements(ref arrayOfNumbers[0], ref arrayOfNumbers[i]);
                Heapify(arrayOfNumbers, i, 0);
            }
            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                Console.Write(arrayOfNumbers[i] + " ");
            }
        }
        void Heapify(int[] arrayOfNumbers, int n, int i)
        {
            int largest = i;  // Initialize largest as root
            int l = 2 * i + 1;  // left = 2*i + 1
            int r = 2 * i + 2;  // right = 2*i + 2

            // If left child is larger than root
            if (l < n && arrayOfNumbers[l] > arrayOfNumbers[largest])
                largest = l;

            // If right child is larger than largest so far
            if (r < n && arrayOfNumbers[r] > arrayOfNumbers[largest])
                largest = r;

            // If largest is not root
            if (largest != i)
            {
                Common.SwapElements(ref arrayOfNumbers[i], ref arrayOfNumbers[largest]);

                // Recursively heapify the affected sub-tree
                Heapify(arrayOfNumbers, n, largest);
            }
        }
    }
}
