using System;

namespace C._Social_Distance
{
    class Program
    {
        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine());
            while (cases-- > 0)
            {
                int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), (item) => Convert.ToInt32(item));
                int[] tables = Array.ConvertAll(Console.ReadLine().ToCharArray(), c => (int)Char.GetNumericValue(c));
                int numberOfTables = input[0];
                int distance = input[1];

                int lastOne = -1;
                int result = 0;

                if(numberOfTables == 1)
                {
                    if(tables[0] == 1)
                    {
                        Console.WriteLine(0);
                    }
                    else
                    {
                        Console.WriteLine(1);
                    }
                    continue;
                }


                int i = 0;
                for (; i < numberOfTables; i++)
                {
                    if (tables[i] == 1 && i > lastOne)
                    {
                        if(i == 0)
                        {
                            lastOne = 0;
                            continue;
                        }
                        int temp;
                        if(lastOne != -1)
                        {
                            temp = i - lastOne - 1;
                            temp = temp - 2 * distance;
                        }
                        else
                        {
                            if(lastOne == -1)
                            {
                                lastOne = 0;
                            }
                            temp = i - lastOne;
                            temp = temp - distance;
                        }
                        
                        temp = Convert.ToInt32(Math.Ceiling((double)temp / (distance+1)));
                        if(temp > 0)
                        {
                            result += temp;
                        }
                        lastOne = i;
                    }
                }
                i--;


                if(lastOne == -1)
                {
                    result += Convert.ToInt32(Math.Ceiling((double)numberOfTables / (distance + 1)));
                }
                else
                {
                    int t = i - lastOne;
                    t = t - distance;
                    t = Convert.ToInt32(Math.Ceiling((double)t / (distance + 1)));
                    if (t > 0)
                    {
                        result += t;
                    }

                }
                Console.WriteLine(result);

            }
        }
    }
}
