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
            //int cases = int.Parse(Console.ReadLine());
            //while (cases-- > 0)
            //{
                int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), (item) => Convert.ToInt32(item));
                int n = input[0];
                int m = input[1];
                int sx = input[2];
                int sy = input[3];
                Console.WriteLine(sx + " " + sy);
                Console.WriteLine("1" + " " + sy);

                int y;
                for (int x =1; x <= n; x++)
                {
                    if(x%2 == 1)
                    {
                        y = 1;
                        while (y <= m)
                        {
                            if((x == sx && y == sy) || (x == 1 && y == sy))
                            {
                                y++;
                                continue;
                            }
                            Console.WriteLine(x + " " + y);
                            y++;
                        }
                    }
                    else
                    {
                        y = m;
                        while(y > 0)
                        {
                            if ((x == sx && y == sy) || (x == 1 && y == sy))
                            {
                                y--;
                                continue;
                            }
                            Console.WriteLine(x + " " + y);
                            y--;
                        }
                    }
                }
            //}
        }
    }
}
