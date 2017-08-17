using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet062_Unique_Paths
    {
        public int UniquePaths(int m, int n)
        {
            int[,] array = new int[m, n];
            array[0, 0] = 1;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == 0)
                    {
                        array[i, j] = 1;
                    }
                    else if (j == 0)
                    {
                        array[i, j] = 1;
                    }
                    else
                    {
                        array[i, j] = array[i - 1, j] + array[i, j - 1];
                    }
                }

            }

            return array[m - 1, n - 1];
        }
    }
}
