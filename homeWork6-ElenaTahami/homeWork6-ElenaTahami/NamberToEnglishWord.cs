using System;
using System.Collections.Generic;
using System.Text;

namespace homeWork6_ElenaTahami
{
    class NamberToEnglishWord
    {
        public string NumberToEnglishWord1To99(int number)
        {
            int thousands = number / 1000;
            int hundreds = (number % 1000) / 100;

            string[] Numbers = new string[] {"Zero", "One", "Two", "Three",
                "Four","Five","Six","Seven","Eight","Nine","Ten", "Eleven", "Twelve",
               "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen","Eighteen","Nineteen"};
            string[] TenNumbers = new string[] { "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

            if (number < 1 || number > 9999)
            {
                return "Invalid Number";
            }


            if (number < 20)
            {
                return Numbers[number];
            }
            int tens = number / 10;
            int ones = number % 10;

            string result = TenNumbers[tens - 2];

            if (ones != 0)
            {
                result += " " + Numbers[ones];
            }
            return result;
        }

        public string NumberToEnglishWord(int number)
        {
            int thousands= number / 1000;
            int hundreds= (number % 1000) / 100;
            int tens= number % 10;
            int ones= number % 10;
            int lastDigits= number % 100;
            string[] Numbers = new string[] {"Zero", "One", "Two", "Three",
                "Four","Five","Six","Seven","Eight","Nine" };

            string result = "";

            if (thousands != 0) {

                result += Numbers[thousands] + " Thousand";
            }

            if (hundreds != 0)
            {
                if(result !="")
                {
                    result += " ";
                }

                result += Numbers[hundreds] + " Hundred";
            }
            if (lastDigits != 0)
            {
                 if( result != "")
                {
                    result += " ";
                }
                result += NumberToEnglishWord1To99(lastDigits);
            }

            return result;
           
        }  
        


        
    }
}
