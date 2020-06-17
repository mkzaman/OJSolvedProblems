using System;

namespace B._Even_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine());
            while (cases-- > 0)
            {
                int lenghtOfArray = int.Parse(Console.ReadLine());
                int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), (item) => Convert.ToInt32(item));

                int oddWrong = 0;
                int evenWrong = 0;
                for (int i = 0; i < lenghtOfArray; i++)
                {
                    if (numbers[i] % 2 != i % 2)
                    {
                        if(i%2==0)
                        {
                            evenWrong++;
                        }
                        else
                        {
                            oddWrong++;
                        }
                    }
                }

                if(oddWrong == evenWrong)
                {
                    Console.WriteLine(evenWrong);
                }
                else
                {
                    Console.WriteLine(-1);
                }

            }
        }
    }
}
