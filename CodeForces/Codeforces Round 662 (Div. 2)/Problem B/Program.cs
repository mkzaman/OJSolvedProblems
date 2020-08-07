using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Solution
{
    class Solution
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), (item) => Convert.ToInt32(item));
            Dictionary<int, int> dic = new Dictionary<int, int>();

            List<int> four = new List<int>();
            List<int> eight = new List<int>();
            List<int> six = new List<int>();
            List<int> two = new List<int>();

            foreach (int x in c)
            {
                if (dic.ContainsKey(x))
                {
                    dic[x]++;

                    if(dic[x] >= 2  && dic[x] < 3)
                    {
                        two.Add(x);
                    }
                    else if(dic[x] >= 4 && dic[x] < 6)
                    {
                        four.Add(x);
                        two.Remove(x);
                    }
                }
                else
                {
                    dic.Add(x, 1);
                }
            }

            int cases = int.Parse(Console.ReadLine());
            while(cases-- > 0)
            {
                string s = Console.ReadLine();
                char n = s[0];
                int p = Convert.ToInt32(s.Substring(2));

                if(n == '+')
                {
                    if (dic.ContainsKey(p))
                    {
                        dic[p]++;
                    }
                    else
                    {
                        dic.Add(p, 1);
                    }
                }
                else
                {
                    dic[p]--;
                }






                    
                    if(fourcount.Count == 0 )
                    {
                        Console.WriteLine("NO");
                    }
                    else if(fourcount.Count == 1)
                    {

                    int fourCountValue = fourcount[0];

                        if (fourCountValue >= 8)
                        {
                            Console.WriteLine("YES");
                        }
                        else
                        {
                            int twocount = dic.Values.Where(x => x >= 2 && x < 4).Count();
                            if (twocount >= 2)
                            {
                                Console.WriteLine("YES");
                            }
                            else if (fourCountValue >= 6 && twocount == 1)
                            {
                                Console.WriteLine("YES");
                            }
                            else
                            {
                                Console.WriteLine("NO");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("YES");
                    }
                //}
            }
        }
    }
}
