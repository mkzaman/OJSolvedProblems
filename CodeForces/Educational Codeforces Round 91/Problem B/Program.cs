using System;
using System.Linq;

namespace Solution
{
    class Solution
    {
        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine());
            while(cases-- > 0)
            {
                string a = Console.ReadLine();
                int countR = a.Count(x => x == 'R');
                int countS = a.Count(x => x == 'S');
                int countP = a.Count(x => x == 'P');

                char max;
                if(countR>=countS && countR>=countP)
                {
                    max = 'P';
                }
                else if(countS>= countR && countS >=countP)
                {
                    max = 'R';
                }
                else
                {
                    max = 'S';
                }

                Console.WriteLine(new string(max, a.Length));
            }
        }
    }
}
