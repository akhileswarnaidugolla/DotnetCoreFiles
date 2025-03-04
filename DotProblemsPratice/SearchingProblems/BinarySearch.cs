using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchingProblems
{
    internal class BinarySearch
    {
        public static int binarySearch(int[] arr, int x)
        {
            int low = 0, high = arr.Length - 1;
            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                if (arr[mid] == x) return mid;
                if (arr[mid] < x) return low = mid + 1;
                if (arr[mid] > x) return high = mid - 1;
            }
            return -1;
        }
 
        public static int binarySerachResursion(int[] arr, int low, int high, int x)
        {
            if (high >= low)
            {
                int mid = low + (high - low) / 2;
                if (arr[mid] == x) return mid;
                if (arr[mid] > x)
                {
                    return binarySerachResursion(arr, low, mid - 1, x);
                }
                if (arr[mid] < x)
                {
                    return binarySerachResursion(arr, mid + 1, high, x);
                }
            }
            return -1;
        }
    }
}
