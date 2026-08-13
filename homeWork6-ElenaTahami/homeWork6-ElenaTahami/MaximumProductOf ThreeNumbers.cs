using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters;
using System.Text;

namespace homeWork6_ElenaTahami
{
    class MaximumProductOf_ThreeNumbers
    {

        public long MaximumOfProductThreeNumber(long[] arrayNumber)
        {



            if (arrayNumber.Length < 3)
            {
                throw new ArgumentException("Array must contain at least 3 elements.");
            }


            Array.Sort(arrayNumber);

             

                long maxValue1 =(long) arrayNumber[0] * arrayNumber[1] * arrayNumber[arrayNumber.Length - 1];



                long maxValue2 =(long) arrayNumber[arrayNumber.Length - 1] * arrayNumber[arrayNumber.Length - 2] * arrayNumber[arrayNumber.Length - 3];



            return Math.Max(maxValue1, maxValue2);
                  
         
            }


        
    }
}