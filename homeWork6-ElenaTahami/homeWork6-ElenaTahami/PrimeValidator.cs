using System;
using System.Collections.Generic;
using System.Text;

namespace homeWork6_ElenaTahami
{
    public class PrimeValidator
    {

        public bool CheckerPrime(int inputnum)

        {
            //if (inputnum < 2)
            //{

            //    return " This Number is a not Prime number";
            //}         

            int sqrtNum = (int)Math.Sqrt(inputnum);

            for (int i=2;i<=sqrtNum ;i++ )
            {
                int remainder = inputnum % i;

             if(remainder==0)
                {

                    return false;
                }   
             



            }

            return true;

        }

          
            
    }
}
