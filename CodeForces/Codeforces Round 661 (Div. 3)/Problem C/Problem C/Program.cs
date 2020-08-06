using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_C
{
    class Program
    {
        static Dictionary<int, int> dic;

        static void combinationUtil(int[] arr,
              int n, int r, int index,
                      int[] data, int i)
        {

            // Current combination is ready to 
            // be printed, print it 
            if (index == r)
            {
                int sum = 0;
                for (int j = 0; j < r; j++)
                    sum += data[j];

                if (dic.ContainsKey(sum))
                {
                    dic[sum]++;
                }
                else
                {
                    dic.Add(sum, 1);
                }



                return;
            }

            // When no more elements are there 
            // to put in data[] 
            if (i >= n)
                return;

            // current is included, put next 
            // at next location 
            data[index] = arr[i];
            combinationUtil(arr, n, r, index + 1,
                                    data, i + 1);

            // current is excluded, replace 
            // it with next (Note that i+1  
            // is passed, but index is not 
            // changed) 
            combinationUtil(arr, n, r, index,
                                    data, i + 1);
        }

        // The main function that prints all 
        // combinations of size r in arr[] of 
        // size n. This function mainly uses 
        // combinationUtil() 
        static void printCombination(int[] arr,
                                    int n, int r)
        {

            // A temporary array to store all 
            // combination one by one 
            int[] data = new int[r];

            // Print all combination using 
            // temprary array 'data[]' 
            combinationUtil(arr, n, r, 0, data, 0);
        }

        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine());
            while(cases-- > 0)
            {
                int len = int.Parse(Console.ReadLine());
                int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), (item) => Convert.ToInt32(item));

                dic = new Dictionary<int, int>();

                printCombination(input, len, 2);

                Console.WriteLine(dic.Values.Max());

                //int[] distinct_element = input.Distinct().ToArray();


                //Dictionary<int, int> dic = new Dictionary<int, int>();
                //for(int i = 0; i<len; i++)
                //{

                //}

                //Dictionary<int, int> moves = new Dictionary<int, int>();


                //int[,] a = new int[distinct_element.Length, distinct_element.Length];

                //for (int i = 0; i<distinct_element.Length; i++)
                //{
                //    for(int j=i; j<distinct_element.Length; j++)
                //    {
                //        a[i,j] = distinct_element[i] + distinct_element[j];
                //    }
                //}

                //for (int i = 0; i < distinct_element.Length; i++)
                //{
                //    for (int j = i; j < distinct_element.Length; j++)
                //    {
                //        if(j == i)
                //        {

                //        }
                //    }
                //}

            }
        }
    }
}
