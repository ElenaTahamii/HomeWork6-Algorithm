using System;
using System.Collections.Generic;
using System.Text;

namespace homeWork6_ElenaTahami
{
    class Fibonacci
    {

        public int Calculate(int n)
        {

            int firstNumber=0;
         int secondNumber = 1;
        int newNumber;

            if (n < 0)
            {
                throw new ArgumentException("Number cannot be negative", nameof(n));
            }


            if (n == 0)
            {
                return 0;
            }

            else if (n == 1)

            {
                return 1;

            }



            else
            {

                for (int i = 2; i <= n; i++)
                {


                    newNumber = firstNumber + secondNumber;
                   firstNumber = secondNumber;
                    secondNumber = newNumber;


                }

                return secondNumber;
            }
        }
    }
}
