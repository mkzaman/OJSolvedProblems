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
                int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), (item) => Convert.ToInt32(item));
                Array.Sort(input);
                string answer = "YES";
                for(int i =0; i<input.Length -1; i++)
                {
                    if(input[i+1] - input[i] > 1 )
                    {
                        answer = "NO";
                        break;
                    }
                }

                Console.WriteLine(answer);

            }
        }
    }
}
