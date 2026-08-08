using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTesting.Classes
{
    public class StringUtils
    {
        public string ReverseTheString(string str)
        {
            char[] ch = str.ToCharArray();
            Array.Reverse(ch);

            return new string(ch);
        }

        public bool CheckPalindrome(string str)
        {
            int start = 0, end = str.Length - 1;

            while(start < end)
            {
                if (str[start] != str[end]) return false;
                start++;
                end--;
            }
            return true;
        }

        public string ToUpperCase(string str)
        {
            return str.ToUpper();
        }
    }
}
