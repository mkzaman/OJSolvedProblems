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
                int a = int.Parse(Console.ReadLine());
                int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), (item) => Convert.ToInt32(item));

                int left = -1, right=-1;
                int mid = -1;
                for(int i=1; i<a; i++)
                {
                    left = -1;
                    right = -1;
                    for (int j=i; j>=0; j--)
                    {
                        if(input[j] < input[i])
                        {
                            left = j;
                            break;
                        }
                    }

                    for(int k= i+1; k<a; k++)
                    {
                        if(input[k] < input[i])
                        {
                            right = k;
                            break;
                        }
                    }

                    if(left != -1 && right != -1)
                    {
                        mid = i;
                        break;
                    }
                }
                if(mid == -1)
                {
                    Console.WriteLine("NO");
                }
                else
                {
                    Console.WriteLine("YES");
                    Console.WriteLine((left + 1) + " " + (mid + 1) + " " + (right + 1));
                }
            }
        }
    }
}
