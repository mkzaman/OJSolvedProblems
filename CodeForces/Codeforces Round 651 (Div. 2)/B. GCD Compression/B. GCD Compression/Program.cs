using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

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
                int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), (item) => Convert.ToInt32(item));

                List<int> odd_index = new List<int>();
                List<int> even_index = new List<int>();

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        even_index.Add(i + 1);
                    }
                    else
                    {
                        odd_index.Add(i + 1);
                    }
                }

                int evenIndexCount = even_index.Count;
                int oddIndexCount = odd_index.Count;

                int evenMax = evenIndexCount % 2 == 1 ? evenIndexCount - 2 : evenIndexCount - 1;
                int oddMax = oddIndexCount % 2 == 1 ? oddIndexCount - 2 : oddIndexCount - 1;

                int evenTaken = 0;
                int oddTaken = 0;

                for (int i = 0; i < n - 1; i++)
                {
                    if (evenMax > evenTaken)
                    {
                        Console.WriteLine(even_index[evenTaken] + " " + even_index[evenTaken + 1]);
                        evenTaken += 2;
                    }
                    else
                    {
                        Console.WriteLine(odd_index[oddTaken] + " " + odd_index[oddTaken + 1]);
                        oddTaken += 2;
                    }
                }
            }
        }
    }
}
