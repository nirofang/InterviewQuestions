using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet063_Unique_Paths_II
    {
        public int UniquePathsWithObstacles(int[,] obstacleGrid)
        {
            int m = obstacleGrid.GetLength(0);
            int n = obstacleGrid.GetLength(1);
            int[,] array = new int[m, n];

            if (obstacleGrid[0, 0] != 1)
            {
                array[0, 0] = 1;
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (i == 0)
                        {
                            if (j > 0 && (obstacleGrid[i, j] == 1 || array[i, j - 1] == 0))
                            {
                                array[i, j] = 0;
                            }
                            else
                            {
                                array[i, j] = 1;
                            }
                        }
                        else if (j == 0)
                        {
                            if (i > 0 && (obstacleGrid[i, j] == 1 || array[i - 1, j] == 0))
                                array[i, j] = 0;
                            else
                                array[i, j] = 1;
                        }
                        else
                        {
                            if (obstacleGrid[i, j] == 1)
                            {
                                array[i, j] = 0;
                            }
                            else
                            {
                                array[i, j] = array[i - 1, j] + array[i, j - 1];
                            }
                        }
                    }
                }
            }

            return array[m - 1, n - 1];
        }
    }
}
