using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchingProblems
{
    internal class LinearSearch
    {
        public static int linearSearch(int[] arr, int x)
        {
            int n = arr.Length - 1;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == x) return i;
            }
            return -1;
        }

    }
}
