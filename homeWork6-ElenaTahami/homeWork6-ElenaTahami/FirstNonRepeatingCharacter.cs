using System;
using System.Collections.Generic;
using System.Text;

namespace homeWork6_ElenaTahami
{
    class FirstNonRepeatingCharacter
    {

        public int FindFirstNonRepeating(string text)
        {
            Dictionary<char, int> result = new Dictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                if (result.ContainsKey(text[i]))
                {
                    result[text[i]]++;
                }
                else
                {
                    result.Add(text[i], 1);
                }
            }

            for (int j = 0; j < text.Length; j++)
            {
                if (result[text[j]] == 1)
                {
                    return text[j];
                }
            }


            return -1;
        }

        

    }
}