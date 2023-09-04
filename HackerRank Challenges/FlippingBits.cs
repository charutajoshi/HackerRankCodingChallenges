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
        public static long flippingBits(Int32 n)
        {
            var nBinary = Convert.ToString(n, 2);
            char[] chars = nBinary.ToCharArray();

            for (int i=0; i<chars.Length; i++)
            {
                if (chars[i] == '0')
                {
                    chars[i] = '1';
                }
                else
                {
                    chars[i] = '0';
                }
            }

            var nBinaryFlipped = new string(chars);
            byte[] bytes = Encoding.ASCII.GetBytes(chars); 
            var flippedBits = (long)BitConverter.ToInt64(bytes);

            return flippedBits; 
        }
    }
}

