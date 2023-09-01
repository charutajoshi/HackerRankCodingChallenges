using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.HackerRank_Challenges
{
    public class TimeConversion
    {
        /// <summary>
        /// Given a time in -hour AM/PM format, convert it to military (24-hour) time.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string timeConversion(string s)
        {
            var stringDate = DateTime.Parse(s);
            string newDate = string.Empty;

            var hour = stringDate.Hour.ToString();
            AddLeadingZero(ref hour);
            var minute = stringDate.Minute.ToString();
            AddLeadingZero(ref minute);
            var second = stringDate.Second.ToString();
            AddLeadingZero(ref second);
            newDate = $"{hour}:{minute}:{second}";
            Console.WriteLine(newDate);

            return newDate.ToString();
        }

        public static void AddLeadingZero(ref string s)
        {
            var integer = Int32.Parse(s);
            if (integer < 10)
            {
                s = "0" + integer.ToString();
            }
        }
    }
}
