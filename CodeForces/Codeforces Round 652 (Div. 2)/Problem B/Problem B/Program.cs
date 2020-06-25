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
                int a = int.Parse(Console.ReadLine());
                string b = Console.ReadLine();


                int firstOne = -1;
                int lastZero = -1;
                for(int i=0; i<a;i++)
                {
                    if(b[i] == '1')
                    {
                        firstOne = i;
                        break;
                    }
                }

                for(int j = a -1; j > -1; j--)
                {
                    if (b[j] == '0')
                    {
                        lastZero = j;
                        break;
                    }

                }

                if(firstOne== -1 || lastZero == -1 || firstOne > lastZero)
                {
                    Console.WriteLine(b);
                    continue;
                }

                string result = b.Substring(0, firstOne) + '0' + b.Substring(lastZero + 1, a - lastZero-1);
                Console.WriteLine(result);
            }
        }
    }
}
