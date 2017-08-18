using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet120_Triangle
    {
        public int MinimumTotal(IList<IList<int>> triangle)
        {
            int min = int.MaxValue;
            if (triangle != null && triangle.Count > 0)
            {
                int n = triangle.Count;
                int[,] matrix = new int[n, n];
                matrix[0, 0] = triangle[0][0];
                for (int i = 1; i < n; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        if (j == 0)
                        {
                            matrix[i, j] = matrix[i - 1, j] + triangle[i][j];
                        }
                        else if (j < i)
                        {
                            matrix[i, j] = Math.Min(matrix[i - 1, j - 1] + triangle[i][j], matrix[i - 1, j] + triangle[i][j]);
                        }
                        else
                        {
                            matrix[i, j] = matrix[i - 1, j - 1] + triangle[i][j];
                        }
                    }
                }
                for (int i = 0; i < n; i++)
                {
                    if (matrix[n - 1, i] < min)
                        min = matrix[n - 1, i];
                }
            }

            return min;
        }
    }
}
