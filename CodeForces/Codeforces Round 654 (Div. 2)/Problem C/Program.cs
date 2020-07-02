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
                Int64[] p = Array.ConvertAll(Console.ReadLine().Split(' '), (item) => Convert.ToInt64(item));
                Int64 a = p[0];
                Int64 b = p[1];
                Int64 m = p[2];
                Int64 n = p[3];

                if(m<=a && n<=b && m<=b && n<=a)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }

            }
        }
    }
}
