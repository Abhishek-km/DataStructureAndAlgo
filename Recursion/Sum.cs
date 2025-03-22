using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    public class Sum
    {
        // Time and Space Complexity is O(n)
        public static int SumtoN(int n)
        {
            if(n==1)
                return 0;

            int previousSum = SumtoN(n-1);
            return previousSum + n;
        }
    }
}
