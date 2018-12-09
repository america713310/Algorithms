using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsDataStructures
{
    class Common
    {
        public static void SwapElements(ref int firstElement, ref int secondElement)
        {
            int _temp = 0;
            _temp = firstElement;
            firstElement = secondElement;
            secondElement = _temp;
        }
    }
}
