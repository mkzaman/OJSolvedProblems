using System;

namespace C._Similar_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine());

            while(cases-- > 0)
            {
                int count = int.Parse(Console.ReadLine());
                int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), (item) => Convert.ToInt32(item));
                Array.Sort(numbers);

                int oddCount = 0;
                int evenCount = 0;
                int diffOneCount = 0;

                if(numbers[0] % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }

                for(int i= 1; i<count; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        evenCount++;
                    }
                    else
                    {
                        oddCount++;
                    }

                    if (numbers[i] - numbers[i-1] == 1 && diffOneCount == 0)
                    {
                        diffOneCount++;
                    }
                }

                if(evenCount % 2 == 0 && oddCount % 2 == 0)
                {
                    Console.WriteLine("YES");
                }
                else if(diffOneCount > 0)
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