using System;

namespace A._Minimal_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            int cases = Convert.ToInt32(Console.ReadLine());
            for(int i =0; i < cases; i++)
            {
                int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), (item) => Convert.ToInt32(item));
                int a = numbers[0];
                int b = numbers[1];

                if (b < a)
                {
                    b *= 2;
                }
                else
                {
                    a *= 2;
                }

                int result = a > b ? a * a : b * b;

                Console.WriteLine(result);
            }
        }
    }
}
