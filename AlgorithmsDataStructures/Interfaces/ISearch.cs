using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsDataStructures.Interfaces
{
    interface ISearch
    {
        int Search(int[] arrayOfNumbers, int start, int end);
        int Search(int[] arrayOfNumbers, int element);
    }
}
