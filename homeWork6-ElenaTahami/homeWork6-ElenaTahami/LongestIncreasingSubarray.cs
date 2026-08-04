using System;
using System.Collections.Generic;
using System.Text;

namespace homeWork6_ElenaTahami
{
    public class LongestIncreasingSubarray
    {
        public int FindLongestLength(int[] array)
        {
            int maxLength = 1;
            int currentLength = 1;

            if (array.Length == 0)
            {
                return 0;
            }          

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[i - 1])
                {
                    currentLength++;

                    if (currentLength > maxLength)
                    {
                        maxLength = currentLength;
                    }                   

                }
                else
                {
                    currentLength = 1;
                }
            }

            return maxLength;
        }
    }
}
