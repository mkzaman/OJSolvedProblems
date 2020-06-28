using System;

namespace Solution
{
    class Solution
    {
        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine());
            while(cases-- > 0)
            {
                int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), (item) => Convert.ToInt32(item));
                int x = a[0];
                int n = a[2];
                int y = a[1];

                int p = n / x;

                if(((p*x)+y) > n)
                {
                    Console.WriteLine((p - 1) * x + y);
                    
                }
                else
                {
                    Console.WriteLine((p * x) + y);
                }
            }
        }
    }
}
