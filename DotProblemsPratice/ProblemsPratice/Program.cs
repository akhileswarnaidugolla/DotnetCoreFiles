namespace ProblemsPratice
{
    internal class Program
    {
        int linearSearch(int[] arr, int x)
        {
            int n = arr.Length - 1;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == x) return i;
            }
            return -1;
        }
        public static void Main(string[] args)
        {

            FindDuplicatesInArray.findDuplicatesInArray();
            //int n=Convert.ToInt32(Console.ReadLine());
            //int[] arr = new int[n];
            //for(int i = 0; i < n; i++)
            //{
            //    arr[i]= Convert.ToInt32(Console.ReadLine());

            //}
            //int [] arr2 = new int[4] {1,2,3,4};

            //Stack<int> st = new Stack<int>();
            //foreach (int i in arr2)
            //    st.Push(i);
            //foreach (int i in st)
            //    Console.WriteLine(i);
            //int[] arr = { 6, 2, 5 };
            //Program a= new Program();
            //try
            //{
            //    int x = Convert.ToInt32(Console.ReadLine());

            //    int result = a.linearSearch(arr, x);
            //    if (result == -1)
            //    {
            //        Console.WriteLine("Element is not there in arr");
            //    }
            //    else
            //    {
            //        Console.WriteLine(result);
            //    }

            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.ToString());

            //}
            //FindDuplicatesInArray.findDuplicatesInArray();
            //WordCountInString.wordCountInString("akhileswar Naidu eswar");
            //ArrayRotation.arrotation([1,2,3,4,5],2);

            //List<int> arr = new List<int>() { 1,8,2,9,4};

            //var a= arr.Where(x => x %2== 0);
            //var b= from x in arr where x >0 select x;

            //foreach (int x in b)
            //{
            //    Console.WriteLine(x);
            //}

            //arr.Add(6);



            
        }
    }
}
