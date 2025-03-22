using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    public  class StairProblem
    {

        // Given n stairs, you can climb 1 or 2 stairs at a time. How many ways can you climb the stairs?

        // Time complexity is O(2^N) and Space complexity is O(N)
        public static int Stair(int n)
        {
            if (n == 1 || n == 0)
                return 1 ;

            int previousways = Stair(n - 1);
            int previous2ways = Stair(n - 2);
            return previousways + previous2ways;

        }
    }
}
