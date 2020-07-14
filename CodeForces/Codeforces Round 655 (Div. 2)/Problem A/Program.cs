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
                for(int i=0; i<a;i++)
                {
                    if(i != a-1)
                    {
                        Console.Write("1 ");
                    }
                    else
                    {
                        Console.WriteLine("1");
                    }
                    
                }

            }
        }
    }
}
