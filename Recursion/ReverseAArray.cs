using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    public class ReverseAArray
    {

        // Time complexity is O(N) and Space complexity is O(N)
        public static void HelperFunction(char[] arr, int start, int end)
        {
            if (start >= end)
                return;

            char temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;

            HelperFunction(arr, start + 1, end - 1);

        }
        public static void ReverseArray(char[] arr)
        {
            HelperFunction(arr, 0, arr.Length - 1);
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }

    }
}
