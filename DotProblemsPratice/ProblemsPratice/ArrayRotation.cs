using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsPratice
{
    internal class ArrayRotation
    {

        public static void arrotation(int[] arr,int r)
        {
            int n = arr.Length-1;
            r = r % n;

            reverse(arr, 0, n);//reverse entire array
            reverse(arr, 0, r-1);//reverse 0 to r-1
            reverse(arr, r, n-1);

            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }
            

        }

        public static void reverse(int[] arr,int start,int end) 
        {
            while (start < end)
            {
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;

            }
        }
        public static void arrayRotation(int[] arr,int r)
        {
            //int[] arr = new int[4] { 1, 6, 8, 9 };
            
            for (int i = 1;i<=r;i++)
            {
                int first = arr[0];
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    arr[j] = arr[j + 1];
                }
                arr[arr.Length - 1] = first;
            }

            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
