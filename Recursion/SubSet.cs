using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    public class SubSet
    {

        // Here i am using char array, and string set, which is helping me to write the code without using a arraylist.
        // doing just for fun, you can use arraylist to store the subset.

        // Time complexity is O(2^n) and space complexity is O(n)
        public static void Helper(char[] arr, string set, int index)
        {
            if (arr.Length == index)
            {
                Console.WriteLine(set);
                return;
            }

            Helper(arr, set + arr[index], index + 1);
            Helper(arr, set, index+1);

        }   
        public static void PrintSubSet(char[] arr) { 
            Helper(arr, "", 0); 
        }
    }
}
