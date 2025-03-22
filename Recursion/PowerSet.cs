using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    public class PowerSet
    {
        public static void Helper(char[] arr, string set, int index)
        {
            if(arr.Length  == index)
            {
                Console.WriteLine(set);
                return; 
            }

                Helper(arr, set + arr[index], index + 1);
                Helper(arr, set, index + 1);

        }
        public static void printPowerSet(char[] arr)
        {
            Helper(arr, "", 0);
        }
    }
}
