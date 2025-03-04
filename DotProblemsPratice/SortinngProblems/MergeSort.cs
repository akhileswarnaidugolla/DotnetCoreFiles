using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SortinngProblems
{
    internal class MergeSort
    {
        public static void print_Name()
        {
            Console.WriteLine("Akhil");
        }
        public void print_Description()
        {
            Console.WriteLine("de");
        }

        public int m()
        {
            //int[] arr = { 12, 7, 14,8,5,0 };

            //mergeSort(arr, 0, arr.Length - 1);
            //foreach (int i in arr)
            //{
            //    Console.WriteLine(i);
            //}
            int[] a = { 1, 1, 2, 1, 3, 5, 1 };
            int ele = -1;
            int count = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (count == 0)
                {
                    ele = a[i];
                    count = 1;
                }
                else if (a[i] == ele)
                {
                    count++;
                }
                else
                {
                    count--;
                }
            }
            count = 0;
            foreach (int n in a)
            {
                if (n == ele)
                {
                    count++;
                }
            }

            if (count > a.Length / 2)
            {
                return ele;
            }
            else
            {
                return -1;
            }
        }
    


        
        public void merge(int[] arr,int l,int m,int r)
        {
            // Find sizes of two
            // subarrays to be merged
            int n1 = m - l + 1;
            int n2 = r - m;

            // Create temp arrays
            int[] L = new int[n1];
            int[] R = new int[n2];
            int i, j;

            // Copy data to temp arrays
            for (i = 0; i < n1; i++)
                L[i] = arr[l + i];
            for (j = 0; j < n2; j++)
                R[j] = arr[m + 1 + j];

            // Merge the temp arrays

            // Initial indexes of first
            // and second subarrays
            i = 0;
            j = 0;

            // Initial index of merged
            // subarray array
            int k = l;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k++] = L[i++];
                    
                }
                else
                {
                    arr[k++] = R[j++];
                    
                }
            }

            // Copy remaining elements
            // of L[] if any
            while (i < n1)
            {
                arr[k++] = L[i++];
               
            }

            // Copy remaining elements
            // of R[] if any
            while (j < n2)
            {
                arr[k++] = R[j++];
                
            }

        }
        public void mergeSort(int[] arr,int low,int high)
        {
          if(low < high)
            {
                int mid = low + (high - low) / 2;

                mergeSort(arr, low, mid);

                mergeSort(arr, mid + 1, high);

                merge(arr,low,mid,high);

            }
        }
    }
}
