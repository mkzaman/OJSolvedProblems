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
                int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), (item) => Convert.ToInt32(item));
                int[] ints = Array.ConvertAll(Console.ReadLine().Split(' '), (item) => Convert.ToInt32(item));
                int[] friends_demands = Array.ConvertAll(Console.ReadLine().Split(' '), (item) => Convert.ToInt32(item));
                int number_of_ints = a[0];
                int number_of_friends = a[1];

                Array.Sort(ints);

                Array.Sort(friends_demands);

                Int64 result = 0;

                int last_one = number_of_ints - 1;
                int first_one = 0;

                foreach(int i in friends_demands)
                {
                    if(i == 1)
                    {
                        result += (ints[last_one] * 2);
                        last_one--;
                    }
                    else
                    {
                        result += ints[last_one];
                        result += ints[first_one];
                        first_one++;
                        last_one--;
                    }
                }

                Console.WriteLine(result);
            }
        }
    }
}
