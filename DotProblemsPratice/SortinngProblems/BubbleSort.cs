using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortinngProblems
{
    internal class BubbleSort
    {
         public void bubbleSort()
        {
            int[] arrayForBubbleSort = new int[8] { 5, 3, 7, 1, 2,8,9,11 };
            int n = arrayForBubbleSort.Length;
            for (int i = 0; i < n-1; i++)
            {     
                bool swapped=false;
                for(int j = 0; j < n-i-1; j++)
                {
                    if (arrayForBubbleSort[j] > arrayForBubbleSort[j+1])
                    {
                        int temp;
                        temp = arrayForBubbleSort[j];
                        arrayForBubbleSort[j] = arrayForBubbleSort[j+1];
                        arrayForBubbleSort[j+1] = temp;
                        swapped = true;
                    }
                    
                }
                if(swapped) {  break; } 
            }
            foreach (int a in arrayForBubbleSort)
            {
                Console.WriteLine(a);
            }

        }
    }
}
