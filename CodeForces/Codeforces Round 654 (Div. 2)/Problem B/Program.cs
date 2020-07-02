using System;

namespace Solution
{
    class Solution
    {
        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine());
            while (cases-- > 0)
            {
                Int64[] a = Array.ConvertAll(Console.ReadLine().Split(' '), (item) => Convert.ToInt64(item));
                Int64 n = a[0];
                Int64 r = a[1];

                Int64 result = 0;

                if(n>r)
                {
                    result = (r * (r + 1)) / 2;
                }
                else
                {
                    result = ((n - 1) * n) / 2;
                    result++;
                }
                Console.WriteLine(result);
            }
        }
    }
}
