using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;
using ConsoleApp1.HackerRank_Challenges; 

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CallCountingSort(); 
        }

        public static void CallSparseArrays()
        {
            int stringsCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> strings = new List<string>();

            for (int i = 0; i < stringsCount; i++)
            {
                string stringsItem = Console.ReadLine();
                strings.Add(stringsItem);
            }

            int queriesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> queries = new List<string>();

            for (int i = 0; i < queriesCount; i++)
            {
                string queriesItem = Console.ReadLine();
                queries.Add(queriesItem);
            }

            List<int> res = SparseArrays.matchingStrings(strings, queries);
            Console.WriteLine(String.Join("\n", res));
        }

        public static void CallLonelyInteger()
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            int result = LonelyInteger.lonelyinteger(a);

            Console.WriteLine(result);
        }

        public static void CallFlippingBits()
        {
            int q = Convert.ToInt32(Console.ReadLine().Trim());

            for (int qItr = 0; qItr < q; qItr++)
            {
                var n = Convert.ToInt32(Console.ReadLine().Trim());

                var result = FlippingBits.flippingBits(n);

                Console.WriteLine(result);
            }
        }

        public static void CallDiagonalDifference()
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            int result = DiagonalDifference.GetDiagonalDifference(arr);

            Console.WriteLine(result);

        }

        public static void CallCountingSort()
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            List<int> result = CountingSort.Sort(arr);

            Console.WriteLine(String.Join(" ", result));
        }
    }
}

