using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.HackerRank_Challenges
{
    /// <summary>
    /// You will be given a list of 32 bit unsigned integers. Flip all the bits (1->0 and 0->1) and return the result as an unsigned integer.
    /// </summary>
    public class FlippingBits
    {
        public static long flippingBits(long n)
        {
            var nBinary = Convert.ToString(n, 2);
            Console.WriteLine(nBinary); 
            char[] chars = nBinary.ToCharArray();

            foreach (var c in chars)
            {
                IEnumerable<char> bytes = IEnumerable;  
                char bit = 'a';

                if (c == '0')
                {
                    bit = '1'; 
                }
                else
                {
                    bit = '0'; 
                }
            }

            return new long(); 
        }
    }
}
