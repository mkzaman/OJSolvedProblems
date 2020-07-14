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
                int a = int.Parse(Console.ReadLine());
                if (a % 2 == 0)
                {
                    int b = a / 2;
                    Console.WriteLine(b + " " + b);
                }
                else
                {
                    int x = (int)Math.Sqrt(a);
                    int min = Int32.MaxValue;
                    for (int y = 3; y <= x; y += 2)
                    {
                        int n = a - y;
                        if(n%y == 0 && min>n)
                        {
                            min = n;
                        }

                        int p = a / y;
                        int m = a - p;
                        if(m % p == 0 && min>m)
                        {
                            min = m;
                        }
                    }
                    if(min == Int32.MaxValue)
                    {
                        Console.WriteLine("1 " + (a - 1));
                    }
                    else
                    {
                        Console.WriteLine((a - min) + " " + min);
                    }
                }
            }
        }
    }
}
