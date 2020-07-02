using System;
using System.Runtime.Serialization;

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
                if (a % 2 == 1)
                {
                    Console.WriteLine(a / 2 + 1);
                }
                else
                {
                    Console.WriteLine(a / 2);
                }
            }
        }
    }
}
