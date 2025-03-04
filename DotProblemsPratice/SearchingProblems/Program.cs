namespace SearchingProblems
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            int[] arr = new int[6] { 1, 2, 5, 6, 8, 10 };
            int[] ar = { 1, 2, 4, 5, 6, 8, 10 };
            int x = 6;
            //int a=binarySearch(arr, x);
            //if(a == -1)
            //{
            //    System.Console.WriteLine("Element is not there in given array");

            //}
            //else
            //{
            //    System.Console.WriteLine(a);
            //}
            //int low=0; int high=arr.Length-1;
            //int y = 100;
            //int b = binarySerachResursion(arr,low,high, y);
            //Console.WriteLine(b);
            Console.WriteLine(LinearSearch.linearSearch(arr, x));
            Console.WriteLine(BinarySearch.binarySearch(arr, x));
            Console.WriteLine(BinarySearch.binarySerachResursion(arr,0,5,x));
            string s = "Akhi234l";

            bool containsInt = s.Any(char.IsDigit);
            bool containsInts = s.All(char.IsDigit);
            Console.WriteLine(containsInt);
            Console.WriteLine(containsInts);







        }
    }
}
