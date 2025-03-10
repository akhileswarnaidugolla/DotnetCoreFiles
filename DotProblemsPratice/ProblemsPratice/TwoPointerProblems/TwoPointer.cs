﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsPratice.TwoPointerProblems
{
    internal class TwoPointer
    {
        // Function to check whether any pair exists
        // whose sum is equal to the given target value
        static bool TwoSum(int[] arr, int target)
        {

            // Sort the array
            Array.Sort(arr);

            int left = 0, right = arr.Length - 1;

            // Iterate while left pointer is less than right
            while (left < right)
            {
                int sum = arr[left] + arr[right];

                // Check if the sum matches the target
                if (sum == target)
                    return true;
                else if (sum < target)
                    left++; // Move left pointer to the right
                else
                    right--; // Move right pointer to the left
            }
            // If no pair is found
            return false;

        }

    

}
}
