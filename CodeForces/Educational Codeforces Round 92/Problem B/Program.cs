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
                string s = Console.ReadLine();
                //int[] x = Array.ConvertAll(Console.ReadLine().Split(' '), (item) => Convert.ToInt32(item));
                //int[] y = Array.ConvertAll(Console.ReadLine().Split(' '), (item) => Convert.ToInt32(item));

                //int n = x[0];
                //int k = x[1];
                //int z = x[2];

                //y = y.Take(k+1).ToArray();

                ////int max = y.Max();


                //int f = 0, l = 0;
                //int max = 0;
                //for(int i=0; i<y.Length-1;i++)
                //{
                //    if(y[i] + y[i+1] > max)
                //    {
                //        f = i;
                //        l = i + 1;
                //        max = y[i] + y[i + 1];
                //    }
                //}

                //int j = 0;
                //int sum = y[0];
                //for(int i=k; i>0;)
                //{
                //    if(j==f && z>0)
                //    {
                //        if(i>1)
                //        {
                //            sum += (y[j] + y[j + 1]);
                //            i -= 2;
                //            z--;
                //        }
                //        else if(i==1)
                //        {
                //            if(y[l] > y[f+1])
                //            {
                //                sum += y[l];
                //                z--;
                //            }
                //            else
                //            {
                //                sum += y[f + 1];
                //            }
                //            i--;
                //        }
                //        continue;
                //    }
                //    j++;
                //    sum += y[j];
                //    i--;
                //}

                //Console.WriteLine(sum);

                if(s.Distinct().Count() == 1)
                {
                    Console.WriteLine("0");
                    continue;
                }

                int max_char = 0;
                for(int i=0; i<=9;i++)
                {
                    int b = Regex.Matches(s, i.ToString()).Count;
                    if(b>max_char)
                    {
                        max_char = b;
                    }
                }

                int max = 0;

                for(int i=0; i<s.Length-1; i++)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append(s[i]);
                    sb.Append(s[i + 1]);
                    int a = Regex.Matches(s, sb.ToString()).Count;
                    if((a*2) > max)
                    {
                        max = a * 2;
                    }
                }

                int answer = max_char > max ? max_char : max;


                Console.WriteLine(s.Length - answer);


            }
        }
    }
}
