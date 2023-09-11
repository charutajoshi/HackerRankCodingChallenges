using System;
namespace ConsoleApp1.HackerRank_Challenges
{
	public class CountingSort
	{
		public CountingSort()
		{
		}

		public static List<int> Sort(List<int> arr)
		{
			var sortedArr = new int[arr.Count()];
			var ogArr = arr.ToArray();

			for (int i = 0; i < arr.Count(); i++)
			{
                for (int j = 0; j < arr.Count(); j++)
                {
					sortedArr[ogArr[i]]++;
				}
            }

			for (int i = 0; i<sortedArr.Count(); i++)
			{
				Console.WriteLine(sortedArr[i]); 
			}

			return sortedArr.ToList(); 
		}
	}
}

