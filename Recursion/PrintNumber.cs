using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    public class PrintNumber
    {
        public static void Print(int n)
        {
            if (n == 0)
                return;
            else
            {
                Console.WriteLine(n); // If we use console.writeline here, it will print in reverse order
                Print(n - 1);
                //Console.WriteLine(n); // If we use console.writeline here, it will print in correct order
            }
        }
    }
}
