using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsPratice
{
    internal class FindDuplicatesInArray
    {
        public static void findDuplicatesInArray()
        {
            int[] arr= new int[10] {1,1,1,3,8,5,6,8,8,9};
            Console.WriteLine("has duplicates in array");
            for (int i = 0; i < arr.Length; i++)
            {
                int counter = 1;
                bool isAlreadyCounted = false;
                for (int j = 0; j < i; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        isAlreadyCounted = true;
                         break;  // Exit the inner loop if the number is already counted
                    }
                }
                if (!isAlreadyCounted)
                {
                    for (int k = i + 1; k < arr.Length; k++)
                    {
                        if (arr[i] == arr[k])
                        {
                            counter++;

                        }
                    }
                    if(counter >= 2)
                    {
                        Console.WriteLine($"Element {arr[i]} appears {counter} times.");
                    }
                    
                } 

               

            }


        }
    }
}
