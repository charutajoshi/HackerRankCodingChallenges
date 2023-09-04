using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.HackerRank_Challenges
{
	public class DiagonalDifference
	{
		public DiagonalDifference()
		{
		}

		public static int GetDiagonalDifference(List<List<int>> arr)
		{
			var sum1 = 0;
			var sum2 = 0;
			var matrix = arr.ToArray();
			var dimension = 0; 

			foreach (var row in matrix)
			{
				dimension++;
			}

            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j < dimension; j++)
                {
					if (j == i)
					{
						sum1 += matrix[i][j]; 
					}
                }
            }


			for (int i = 0; i < dimension; i++)
			{
                for (int j = dimension; j > 0; j--)
                {
					if (i + j == dimension - 1)
					{
                        sum2 += matrix[i][j];
                    }
					else if (j == 1)
					{
                        if (i + 0 == dimension - 1)
                        {
                            sum2 += matrix[i][0];
                        }
                    }
                }
            }

			/*
			 3x3
			0,2
			1,1
			2,0
			
			 4x4
			0,3
			1,2
			2,1
			3,0
			
			 5x5
			0,4
			1,3
			2,2
			3,1
			4,0
			
			 6x6
			0,5
			1,4
			2,3
			3,2
			4,1
			5,0
			*/

            return Math.Abs((sum1-sum2)); 
		}
	}
}

