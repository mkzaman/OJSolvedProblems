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
                int[] tables = Array.ConvertAll(Console.ReadLine().ToCharArray(), (item) => Convert.ToInt32(item));
                int numberOfTables = input[0];
                int distance = input[1];

                int positionOfLastOne = -1;
                int positionOfNextOne = -1;
                int result = 0;

                for (int i = 0; i < numberOfTables;)
                {
                    if (tables[i] == 1)
                    {
                        int temp;
                        if(i-positionOfLastOne > i)
                        {
                            temp = i - 0 - distance;
                            positionOfLastOne = i;
                        }
                        else
                        {
                            temp = i - positionOfLastOne - 2 * distance;
                            positionOfLastOne = i;
                        }

                        if(temp > 0)
                        {

                        }

                        for (int j = i + 1; j < numberOfTables; j++)
                        {
                            if(tables[j] == 1)
                            {
                                positionOfNextOne = j;
                                break;
                            }
                        }
                        if(positionOfNextOne == positionOfLastOne)
                        {

                        }
                    }
                    i++;
                }
            }
        }
    }
}
