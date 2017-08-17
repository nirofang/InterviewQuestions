using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet059_Spiral_Matrix_II
    {
        public int[,] GenerateMatrix(int n)
        {
            if (n > 0)
            {
                int[,] matrix = new int[n, n];
                int direction = 0;
                int i = 0, j = 0;
                int num = 1;
                while (num <= n * n)
                {
                    matrix[i, j] = num;
                    if (direction == 0)
                    {
                        if ((j + 1 == n || matrix[i, j + 1] != 0))
                            direction = 1;
                        else
                            j++;
                    }

                    if (direction == 1)
                    {
                        if ((i + 1 == n || matrix[i + 1, j] != 0))
                            direction = 2;
                        else
                            i++;
                    }

                    if (direction == 2)
                    {
                        if ((j == 0 || matrix[i, j - 1] != 0))
                            direction = 3;
                        else
                            j--;
                    }
                    if (direction == 3)
                    {
                        if (i == 0 || matrix[i - 1, j] != 0)
                        {
                            direction = 0;
                            j++;
                        }
                        else
                        {
                            i--;
                        }
                    }
                    num++;
                }
                return matrix;
            }
            return new int[0, 0];
            
        }
    }
}
