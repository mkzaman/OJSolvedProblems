using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Solution
{
    class Solution
    {
        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine());
            while(cases-- > 0)
            {
                int x = int.Parse(Console.ReadLine());
                StringBuilder sb = new StringBuilder();

                int a = x % 4 == 0 ? x / 4 : x / 4 + 1;

                int b = x - a;

                for (int i = 0; i < b; i++)
                {
                    sb.Append('9');
                }
                for (int i = 0; i < a; i++)
                {
                    sb.Append('8');
                }

                Console.WriteLine(sb);
            }
        }
    }
}
