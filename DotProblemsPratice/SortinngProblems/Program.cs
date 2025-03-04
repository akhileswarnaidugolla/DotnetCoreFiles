using System.Collections;
using System.Runtime.CompilerServices;
using System.Text;

namespace SortinngProblems
{
       
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<int> list= new List<int>() { 1,2,3,4};

            list.Add(6);
            var a=list.Where(x=>x>0);
            Console.WriteLine(a);

            foreach(var x in a) Console.WriteLine(x);
;                
            //MergeSort.print_Name();
            //MergeSort.print_Description();
            //    Console.WriteLine("Hello, World!");
            //    //BubbleSort b=new BubbleSort();
            //    //b.bubbleSort();
            //    //int[] arr = { 12, 11, 5, 6, 7, 14 };

            //    MergeSort me = new MergeSort();
            //    Console.WriteLine(me.m());
            //    //int[] a = new int[] { 1, 2, 0, 1, 2, 0, 1, 0, 0 };
            //    //int low = 0;
            //    //int high = a.Length - 1;
            //    //int mid = 0;
            //    //while (mid <= high)
            //    //{
            //    //    if (a[mid] == 0)
            //    //    {
            //    //        swape(a, low, mid);
            //    //        low++;
            //    //        mid++;
            //    //    }
            //    //    else if (a[mid] == 1)
            //    //    {
            //    //        mid++;
            //    //    }
            //    //    else if (a[mid] == 2)
            //    //    {
            //    //        swape(a, mid, high);
            //    //        high--;
            //    //    }

            //    //}
            //    //foreach (var l in a)
            //    //{
            //    //    Console.WriteLine(l);
            //    //}

            //    List<int> list = new List<int>() { 1,2,4,6};

            //    var a=list.Where(x => x % 2==0);

            //    var b= from x in list where x % 2==0 select x;\



            //    list.Add(10);
            //    foreach (int x in list)
            //    {
            //        Console.WriteLine(x);
            //    }








        }
    }
}
