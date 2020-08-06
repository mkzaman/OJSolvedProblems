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
                int a = int.Parse(Console.ReadLine());
                int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), (item) => Convert.ToInt32(item));
                int[] o = Array.ConvertAll(Console.ReadLine().Split(' '), (item) => Convert.ToInt32(item));

                int min_c = c.Min();
                int min_o = o.Min();

                Int64 move = 0;
                for(int i = 0; i< a; i++)
                {
                    int om = 0;
                    int cm = 0;
                    if(c[i] != min_c)
                    {
                        cm = c[i] - min_c;
                    }
                    if(o[i] != min_o)
                    {
                        om = o[i] - min_o;
                    }

                    if(om > 0 && cm > 0)
                    {
                        int temp = Math.Min(om, cm);
                        move += temp;
                        om -= temp;
                        cm -= temp;
                        if(om != 0)
                        {
                            move += om;
                        }
                        else
                        {
                            move += cm;
                        }
                    }
                    else if(om > 0)
                    {
                        move += om;
                    }
                    else if(cm > 0)
                    {
                        move += cm;
                    }
                }

                Console.WriteLine(move);
            }
        }
    }
}
