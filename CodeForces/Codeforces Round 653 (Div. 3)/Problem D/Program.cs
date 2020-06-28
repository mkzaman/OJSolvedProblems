using System;
using System.Collections.Generic;
using System.Linq;

namespace Solution
{
    class Solution
    {
        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine());
            while (cases-- > 0)
            {
                int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), (item) => Convert.ToInt32(item));
                int[] ints = Array.ConvertAll(Console.ReadLine().Split(' '), (item) => Convert.ToInt32(item));
                int x = a[0];
                int y = a[1];
                Dictionary<int, Int64> dic = new Dictionary<int, Int64>();
                int result = 0;
                foreach (int p in ints)
                {
                    if (p % y == 0)
                    {
                        continue;
                    }

                    int needed = p < y ? y - p : (((p / y) + 1) * y) - p;
                    if (!dic.ContainsKey(needed))
                    {
                        dic[needed] = needed;
                    }
                    else
                    {
                        dic[needed] += y;
                    }
                    result++;
                }

                
                if (result == 0)
                {
                    Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine(dic.Values.Max()+1);
                }
            }
        }
    }
}
