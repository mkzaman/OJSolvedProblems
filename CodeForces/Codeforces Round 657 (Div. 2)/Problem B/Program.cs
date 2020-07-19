using System;
using System.Security.Cryptography.X509Certificates;

namespace Solution
{
    class Solution
    {
        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine());
            while (cases-- > 0)
            {
                Int64[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), (item) => Convert.ToInt64(item));
                Int64 l = arr[0];
                Int64 r = arr[1];
                Int64 m = arr[2];

                Int64 a =0, b=0, c = 0;
                for(Int64 i =l; i<=r; i++)
                {
                    bool neg = true;
                    Int64 minus = m % i;
                    Int64 p = (Int64)Math.Ceiling((double)m / i);
                    Int64 plus = p * i - m;

                    Int64 x = Math.Min(minus, plus);
                    if (m < l)
                    {
                        x = plus;
                    }
                    

                    if(x == plus)
                    {
                        neg = false;
                    }
                    if(r-l >=x)
                    {
                        a = i;
                        if(neg)
                        {
                            b = r;
                            c = r - x;
                        }
                        else
                        {
                            c = r;
                            b = r - x;
                        }

                        if(m+c-b == 0)
                        {
                            continue;
                        }    

                        break;
                    }
                }
                Console.WriteLine(a + " " + b + " " + c);
            }
        }
    }
}
