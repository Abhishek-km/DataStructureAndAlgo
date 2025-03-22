using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    public class Palindrom
    {

        // Time and Space complexity is O(N)
        public static bool helperPalindrom(string str, int start, int end)
        {
            if (start >= end)
                return true;
            if (str[start] != str[end])
                return false;
            return helperPalindrom(str, start + 1, end - 1);
        }
        public static bool PalindromCheck(string str) { 
        
        return helperPalindrom(str, 0, str.Length - 1);
        }
    }
}
