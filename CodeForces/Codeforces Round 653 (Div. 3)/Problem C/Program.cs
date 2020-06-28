using System;
using System.Collections.Generic;

namespace Solution
{
    class Solution
    {
        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine());
            while(cases-- > 0)
            {
                int len = int.Parse(Console.ReadLine());
                string input = Console.ReadLine();

                Stack<char> madStack = new Stack<char>();

                int result = 0;
                foreach(char c in input)
                {
                    if(c == '(')
                    {
                        madStack.Push(c);
                    }
                    else
                    {
                        if(madStack.Count > 0)
                        {
                            madStack.Pop();
                        }
                        else
                        {
                            result++;
                        }
                    }
                }
                Console.WriteLine(result);
            }
        }
    }
}
