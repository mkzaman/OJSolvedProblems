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
                int n = int.Parse(Console.ReadLine());
                if(n <= 30)
                {
                    Console.WriteLine("NO");
                }
                else
                {
                    Console.WriteLine("YES");
                    if(n==36)
                    {
                        Console.WriteLine("5 6 10 15");
                    }
                    else if(n==40)
                    {
                        Console.WriteLine("6 10 15 9");
                    }
                    else if(n==44)
                    {
                        Console.WriteLine("6 7 10 21");
                    }
                    else
                    {
                        Console.WriteLine("6 10 14 " + (n - 30));
                    }
                }
            }
        }
    }
}
