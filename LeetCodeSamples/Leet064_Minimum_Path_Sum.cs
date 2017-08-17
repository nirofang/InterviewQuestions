using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet064_Minimum_Path_Sum
    {
        public int MinPathSum(int[,] grid)
        {
            int[,] sums = new int[grid.GetLength(0), grid.GetLength(1)];
            int rowLen = grid.GetLength(0);
            int colLen = grid.GetLength(1);
            sums[0, 0] = grid[0, 0];
            for (int i = 0; i < rowLen; i++)
            {
                for (int j = 0; j < colLen; j++)
                {
                    if (i == 0 && j > 0)
                    {
                        sums[0, j] = sums[0, j - 1] + grid[0, j];
                    }
                    else if (i > 0 && j == 0)
                    {
                        sums[i, 0] = sums[i - 1, 0] + grid[i, 0];
                    }
                    else if (i > 0 && j > 0)
                    {
                        sums[i, j] = Math.Min(sums[i - 1, j], sums[i, j - 1]) + grid[i, j];
                    }
                }
            }
            return sums[rowLen - 1, colLen - 1];
        }
    }
}
