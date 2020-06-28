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
                if(n%3 != 0 && n!=1)
                {
                    Console.WriteLine(-1);
                }
                else
                {
                    int count = 0;
                    while(true)
                    {
                        if(n == 1)
                        {
                            break;
                        }
                        else if(n%6 == 0)
                        {
                            count++;
                            n /= 6;
                        }
                        else if(n%3 == 0)
                        {
                            count++;
                            n *= 2;
                        }
                        else
                        {
                            count = -1;
                            break;
                        }
                    }
                    if(count == -1)
                    {
                        Console.WriteLine(-1);
                    }
                    else
                    {
                        Console.WriteLine(count);
                    }
                }

            }
        }
    }
}
