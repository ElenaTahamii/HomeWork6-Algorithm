using System;
using System.Collections.Generic;
using System.Text;

namespace homeWork6_ElenaTahami
{
    class TargetSumFinder
    {

        public bool SumFinder(int[] array, int target)
        {

            HashSet<int> seenNumbers = new HashSet<int>();
            for (int i = 0; i < array.Length; i++)
            {

                if (seenNumbers.Contains( target - array[i]))
                {
                    return true;

                }
                seenNumbers.Add(array[i]);
            }

            return false;

        }
    }


}

