using System;
using System.Collections.Generic;
using System.Text;

namespace homeWork6_ElenaTahami
{
    class ReverseInputNumber
    {


        public int ReverseInteger(int value)
        {
            long reverse = 0;

            while (value != 0)
            {
                int digit = value % 10;

                value = value / 10;

                if (reverse > int.MaxValue || reverse < int.MinValue)
                {
                    return 0;
                }

                reverse = reverse * 10 + digit;
            }

            return (int)reverse;
        }
    }
}