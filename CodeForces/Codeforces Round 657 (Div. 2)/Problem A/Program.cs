using System;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Solution
{
    class Solution
    {
        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine());
            while (cases-- > 0)
            {
                int len = int.Parse(Console.ReadLine());
                string s = Console.ReadLine();
                int a = -1;
                string[] left = { "a", "ab", "aba", "abac", "abaca", "abacab" };
                string[] right = { "bacaba", "acaba", "caba", "aba", "ba", "a" };
                string p = "abacaba";
                a = s.IndexOf(p);

                if (a != -1)
                {
                    string x = s.Substring(a + 4, s.Length - (a + 4));

                    if (x.Contains("abacaba"))
                    {
                        Console.WriteLine("NO");
                        continue;
                    }
                }
                //else
                //{
                    
                    if (s.Contains("?") && a != -1)
                    {
                        int slen = s.Length;
                        for (int i = 0; i < slen; i++)
                        {
                            StringBuilder sb = new StringBuilder(s);
                            if (i + 6 < slen)
                            {
                                if (sb[i] == 'a' || sb[i] == '?')
                                {
                                    sb[i] = 'a';
                                }
                                if (sb[i+1] == 'b' || sb[i + 1] == '?')
                                {
                                    sb[i + 1] = 'b';
                                }
                                if (sb[i + 2] == 'a' || sb[i + 2] == '?')
                                {
                                    sb[i + 2] = 'a';
                                }
                                if (sb[i + 3] == 'c' || sb[i + 3] == '?')
                                {
                                    sb[i + 3] = 'c';
                                }
                                if (sb[i + 4] == 'a' || sb[i + 4] == '?')
                                {
                                    sb[i + 4] = 'a';
                                }
                                if (sb[i + 5] == 'b' || sb[i + 5] == '?')
                                {
                                    sb[i + 5] = 'b';
                                }
                                if (sb[i + 6] == 'a' || sb[i + 6] == '?')
                                {
                                    sb[i + 6] = 'a';
                                }
                            }
                            string news = sb.ToString();
                            if (news.Contains(p))
                            {
                                news.Replace('?', 'd');
                                Console.WriteLine(news);
                                Console.WriteLine("YES");
                            }
                        }
                    }
                    else
                    {
                        s.Replace('?', 'd');
                        Console.WriteLine(s);
                        Console.WriteLine("YES");
                    }
                //}


            }
        }
    }
}
