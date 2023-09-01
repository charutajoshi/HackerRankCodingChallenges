using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.HackerRank_Challenges
{
    /// <summary>
    /// Given five positive integers, find the minimum and maximum values that can be calculated by summing exactly four of the five integers. 
    /// Then print the respective minimum and maximum values as a single line of two space-separated long integers.
    /// </summary>
    public class MinMaxSum
    {
        public static void miniMaxSum(List<int> arr)
        {
            List<double> sums = new List<double>();

            for (int i = 0; i < arr.Count; i++)
            {
                List<double> nums = new List<double>();

                for (int j = 0; j < arr.Count; j++)
                {
                    if (!(j == i))
                    {
                        nums.Add(Convert.ToDouble(arr[j]));
                    }
                }

                double sum = 0;
                foreach (var tempNum in nums)
                {
                    sum = sum + tempNum;
                }

                //Console.WriteLine(sum);
                sums.Add(sum);
            }

            var min = Int64.MaxValue;
            Int64 max = 0;

            foreach (var number in sums)
            {
                if (number < min)
                {
                    min = Convert.ToInt64(number);
                }

                if (number > max)
                {
                    max = Convert.ToInt64(number);
                }
            }


            Console.WriteLine($"{min} {max}");
        }
    }
}
