using System;
using System.Linq;

namespace Soltuion
{
    class Soltuion
    {
        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine());
            while (cases-- > 0)
            {
                int a = int.Parse(Console.ReadLine());
                int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), (item) => Convert.ToInt32(item));

                int max = input.Max();
                int min = input.Min();

                if (max == 0)
                {
                    for (int i = 0; i <= input.Length; i++)
                    {
                        if (i % 2 == 0)
                        {
                            Console.WriteLine("a");
                        }
                        else
                        {
                            Console.WriteLine("b");
                        }

                    }
                }
                else if(min != 0)
                {
                    foreach(int p in input)
                    {
                        Console.WriteLine(new string('a', p));
                        if(p == max)
                        {
                            Console.WriteLine(new string('a', p+1));
                        }
                    }
                }
                else
                {
                    char last = 'a';
                    for (int i = 0; i < input.Length; i++)
                    {
                        if (input[i] == 0)
                        {
                            if (i == 0)
                            {
                                Console.WriteLine("a");
                            }

                            last = last == 'a' ? 'b' : 'a';


                            if (i == input.Length - 1)
                            {
                                Console.WriteLine(new string(last, 1));
                            }
                            else
                            {
                                if (input[i + 1] == 0)
                                {
                                    Console.WriteLine(new string(last, 1));
                                }
                                else
                                {
                                    Console.WriteLine(new string(last, input[i + 1]));
                                }

                            }
                        }
                        else
                        {
                            
                            if (i == 0)
                            {
                                Console.WriteLine(new string(last, input[i]));
                                if (input.Length > 1)
                                {

                                        if(input[i+1] > input[i])
                                        {
                                            Console.WriteLine(new string(last, input[i + 1]));
                                        }
                                        else
                                        {
                                            Console.WriteLine(new string(last, input[i]));
                                        }
                                }
                                else
                                {
                                    Console.WriteLine(new string(last, input[i]));
                                }
                            }
                            else
                            {
                                if(input.Length-1 == i)
                                {
                                    Console.WriteLine(new string(last, input[i]));
                                }
                                else
                                {
                                    //if (input[i + 1] > input[i])
                                    //{
                                    //    Console.WriteLine(new string(last, input[i + 1]));
                                    //}
                                    //else
                                    {
                                        Console.WriteLine(new string(last, input[i]));
                                    }
                                }
                            }

                        }

                    }
                }
            }
        }
    }
}
