using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace homeWork6_ElenaTahami
{
    class TriangleValidation
    {

        public bool CalculateTriangleValidation(int[] arrayNumbers)
        {

            if ( arrayNumbers.Length==null && arrayNumbers.Length < 3)
            {
                return false;
            }

            for (int i= 0; i < arrayNumbers.Length; i++)
            {

                for (int j= i + 1; j < arrayNumbers.Length; j++)
                {

                    for (int k= j + 1; k < arrayNumbers.Length; k++)
                    {
                        int a = arrayNumbers[i];
                        int b = arrayNumbers[j];
                        int c = arrayNumbers[k];

                        if (a + b > c && a + c > b && b + c > a)
                        {

                            return true;

                        }                      

                    }

                }


            }

            return false;

        }
    }

}