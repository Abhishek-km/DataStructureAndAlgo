using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    public class Factorial
    {

        // Time and Space Complexity is O(n)
        public static int  CalFactorail(int n)
        {
            if ( n== 1)
                return 1;

            int previousFactorial = CalFactorail(n - 1);
            return previousFactorial * n;
        }
    }
}
