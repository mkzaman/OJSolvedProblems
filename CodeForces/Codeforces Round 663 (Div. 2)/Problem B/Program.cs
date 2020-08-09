using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace Solution
{
    class Solution
    {
        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine());
            while (cases-- > 0)
            {
                int n, m;
                int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), (item) => Convert.ToInt32(item));
                n = input[0];
                m = input[1];

                int count = 0;

                for(int i = 1; i<=n; i++)
                {
                    string s = Console.ReadLine();

                    if(i == n)
                    {
                        for(int j=0; j<m-1; j++)
                        {
                            if(s[j] == 'D')
                            {
                                count++;
                            }
                        }
                    }
                    else
                    {
                        if(s[m-1] == 'R')
                        {
                            count++;
                        }
                    }

                }
                Console.WriteLine(count);
            }
        }
    }
}
