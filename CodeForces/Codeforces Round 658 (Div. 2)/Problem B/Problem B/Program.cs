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
                int len = int.Parse(Console.ReadLine());
                int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), (item) => Convert.ToInt32(item));

                int b = Array.Find(a, x => x != 1);

                if (b == 0)
                {
                    if (len % 2 == 0)
                    {
                        Console.WriteLine("Second");
                    }
                    else
                    {
                        Console.WriteLine("First");
                    }
                }
                else
                {
                    int c = Array.FindIndex(a, x=> x == b);
                    if(c%2 == 0)
                    {
                        Console.WriteLine("First");
                    }
                    else
                    {
                        Console.WriteLine("Second");
                    }
                }
            }
        }
    }
}
