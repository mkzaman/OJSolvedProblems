using System;
using System.Collections.Generic;

namespace Solution
{
    class Solution
    {
        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine());
            while (cases-- > 0)
            {
                int[] d = Array.ConvertAll(Console.ReadLine().Split(' '), (item) => Convert.ToInt32(item));
                int x = d[0];
                int y = d[1];
                int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), (item) => Convert.ToInt32(item));
                int[] b = Array.ConvertAll(Console.ReadLine().Split(' '), (item) => Convert.ToInt32(item));

                bool s = false;
                int q = 0;
                for(int i =0; i<x; i++)
                {
                    for(int j=0; j<y; j++)
                    {
                        if(a[i] == b[j])
                        {
                            s = true;
                            q = a[i];
                            break;
                        }
                    }
                    if(s == true)
                    {
                        break;
                    }
                }

                if(s==true)
                {
                    Console.WriteLine("YES");
                    Console.WriteLine("1 " + q);
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
        }
    }
}
