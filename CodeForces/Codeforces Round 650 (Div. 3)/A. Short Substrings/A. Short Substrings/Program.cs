using System;

namespace A._Short_Substrings
{
    class Program
    {
        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine());
            while(cases-- > 0)
            {
                string input = Console.ReadLine();
                string output = string.Empty;

                output += input[0];
                for (int i = 2; i < input.Length; i += 2)
                {
                    output += input[i];
                }
                output += input[input.Length - 1];

                Console.WriteLine(output);
            }
        }
    }
}
