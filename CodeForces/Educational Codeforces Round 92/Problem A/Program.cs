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
                int a = input[0];
                int b = input[1];

                if(a*2 <= b)
                {
                    Console.WriteLine(a + " " + a * 2);
                }
                else
                {
                    Console.WriteLine("-1 -1");
                }

            }
        }
    }
}
