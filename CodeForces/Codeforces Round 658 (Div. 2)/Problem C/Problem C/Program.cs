using System;
using System.Collections.Generic;

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

                int[] input = Array.ConvertAll(Console.ReadLine().ToCharArray(), c => (int)Char.GetNumericValue(c));
                int[] output = Array.ConvertAll(Console.ReadLine().ToCharArray(), c => (int)Char.GetNumericValue(c));

                List<int> steps = new List<int>();

                for (int l = len - 1; l >= 0; l--)
                {
                    if (input[0] == output[l])
                    {
                        steps.Add(1);
                        input[0] = input[0] == 1 ? 0 : 1;
                    }

                    steps.Add(l + 1);
                    int[] temp = new int[l + 1];
                    Array.Copy(input, 0, temp, 0, l + 1);
                    Array.Reverse(temp);
                    for (int i = 0; i <= l; i++)
                    {
                        if (temp[i] == 1)
                        {
                            input[i] = 0;
                        }
                        else
                        {
                            input[i] = 1;
                        }
                    }
                }

                int count = steps.Count;
                Console.Write(count + " ");

                for (int i = 0; i < count; i++)
                {
                    if (i == count - 1)
                    {
                        Console.WriteLine(steps[i]);
                    }
                    else
                    {
                        Console.Write(steps[i] + " ");
                    }
                }
            }
        }
    }
}
