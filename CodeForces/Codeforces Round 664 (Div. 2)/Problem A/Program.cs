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
                int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), (item) => Convert.ToInt32(item));
                int r, g, b, w;
                r = input[0];
                g = input[1];
                b = input[2];
                w = input[3];

                if(r == g && g == b && b == w)
                {
                    Console.WriteLine("Yes");
                }
                else if(r%2 == 0 && g % 2 == 0&& b %2 == 0)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    int zero = 0;
                    int odd = 0;
                    int even = 0;

                    if(r == 0)
                    {
                        zero++;
                    }
                    else if(r %2 == 0)
                    {
                        even++;
                    }
                    else
                    {
                        odd++;
                    }

                    if (g == 0)
                    {
                        zero++;
                    }
                    else if (g % 2 == 0)
                    {
                        even++;
                    }
                    else
                    {
                        odd++;
                    }

                    if (b == 0)
                    {
                        zero++;
                    }
                    else if (b % 2 == 0)
                    {
                        even++;
                    }
                    else
                    {
                        odd++;
                    }

                    if(zero == 3)
                    {
                        Console.WriteLine("YES");
                    }
                    else if(zero == 2)
                    {
                        if(odd == 1 && w % 2 == 1)
                        {
                            Console.WriteLine("NO");
                        }
                        else
                        {
                            Console.WriteLine("YES");
                        }
                    }
                    else if(zero == 1)
                    {
                        if(odd == 2 || (odd == 1 && w % 2 == 1))
                        {
                            Console.WriteLine("NO");
                        }
                        else
                        {
                            Console.WriteLine("YES");
                        }
                    }
                    else
                    {
                        if((odd == 2 && w%2 == 1) || (odd == 1 && w%2 == 0) || (odd == 3))
                        {
                            Console.WriteLine("YES");
                        }
                        else
                        {
                            Console.WriteLine("NO");
                        }
                    }
                }
            }
        }
    }
}
