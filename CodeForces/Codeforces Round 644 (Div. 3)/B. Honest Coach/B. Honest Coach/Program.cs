using System;

namespace B._Honest_Coach
{
    class Program
    {
        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine());
            while (cases-- > 0)
            {
                int number_of_athlets = int.Parse(Console.ReadLine());
                int[] athlets = Array.ConvertAll(Console.ReadLine().Split(' '), (item) => Convert.ToInt32(item));
                Array.Sort(athlets);

                int answer = Int32.MaxValue;
                for(int i = 1; i<number_of_athlets; i++)
                {
                    int temp = athlets[i] - athlets[i - 1];
                    if (temp < answer)
                    {
                        answer = temp;
                    }
                }
                Console.WriteLine(answer);
            }
        }
    }
}
