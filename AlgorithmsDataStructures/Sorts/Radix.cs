using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsDataStructures.Sorts
{
    class Radix
    {
        public static void Sort(ref int[] data)
        {
            int i, j;
            int[] temp = new int[data.Length];

            for (int shift = 31; shift > -1; --shift)
            {
                j = 0;

                for (i = 0; i < data.Length; ++i)
                {
                    bool move = (data[i] << shift) >= 0;

                    if (shift == 0 ? !move : move)
                        data[i - j] = data[i];
                    else
                        temp[j++] = data[i];
                }

                Array.Copy(temp, 0, data, data.Length - j, j);
            }
        }
    }
}
