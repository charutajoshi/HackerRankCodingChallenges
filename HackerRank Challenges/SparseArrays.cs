using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.HackerRank_Challenges
{
    /// <summary>
    /// There is a collection of input strings and a collection of query strings. For each query string, determine how many times it occurs in the list of input strings. 
    /// Return an array of the results.
    /// </summary>
    public class SparseArrays
    {
        public static List<int> matchingStrings(List<string> strings, List<string> queries)
        {
            List<int> result = new List<int>();

            foreach (string q in queries)
            {
                int count = 0; 
                foreach (string s in strings)
                {
                    if (q == s)
                    {
                        count++;
                    }
                }
                result.Add(count);
            }

            return result; 
        }
    }
}
