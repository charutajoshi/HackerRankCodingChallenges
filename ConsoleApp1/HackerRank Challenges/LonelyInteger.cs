using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.HackerRank_Challenges
{
    /// <summary>
    /// Given an array of integers, where all elements but one occur twice, find the unique element.
    /// </summary>
    public class LonelyInteger
    {
        public static int lonelyinteger(List<int> a)
        {
            // Below function uses .NET LINQ to get the count of occurances of an integer. 
            // If the integer occurs only once in the list then return that integer
            //foreach (int num in a)
            //{
            //    var test1 = a.Select(integer => integer).Where(number => number == num).ToList().Count;

            //    if (test1 == 1)
            //    {
            //        return num; 
            //    }
            //}

            // Below method uses XOR operator (^) to perform bitwise function. This operator performs XOR operation on the bits that underly the integer
            // XOR operation entails comparing each integer's bits with the other's to determine if each bit matches between the two.
            // If yes, then result = 1 (true).
            // If no, then result = 0 (false)
            // Example: integer 1 = 01 in binary; integer 2 = 10 in binary
            // If we perform 01 ^ 10 the result is 11 in binary (3 in integer)
            // because the 1 and 0 in the one's place do not match, and the 0 and 1 in the two's place do not match 
            // Example 2: integer 5 = 101 in binary; integer 7 = 111 in binary 
            // If we perform 101 ^ 111 the result is 010 in binary (2 in integer)
            // because the 1 and 1 match in the one's place, the 0 and 1 don't match in the two's place, and the 1 and 1 match in the three's place
            int res = a[0];
            for (int x = 1; x < a.Count; x++)
            {
                Console.WriteLine(Convert.ToString(res, 2) + $" = {res}");
                Console.WriteLine(Convert.ToString(a[x], 2) + $" = {a[x]}");
                res = res ^ a[x];
                Console.WriteLine(Convert.ToString(res, 2) + $" = {res}");
            }
            return res;
            // I still don't understand how this solution works every time with any array length / list count

            //return 0; 
        }
    }
}
