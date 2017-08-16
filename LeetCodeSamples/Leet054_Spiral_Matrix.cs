using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamplesTests
{
    public class Leet054_Spiral_Matrix
    {
        public IList<int> SpiralOrder(int[,] matrix)
        {
            IList<int> list = new List<int>();
            if (matrix != null)
            {
                int n = matrix.GetLength(0);
                int m = matrix.GetLength(1);
                int direction = 0;
                if (n > 0)
                {
                    int[,] used = new int[n, m];
                    int i = 0, j = 0;
                    while (i >= 0 && i < n && j >= 0 && j < m && used[i, j] == 0)
                    {
                        list.Add(matrix[i, j]);
                        used[i, j] = 1;

                        if (direction == 0)
                        {
                            if ((j + 1 == m || used[i, j + 1] == 1))
                                direction = 1;
                            else
                                j++;
                        }

                        if (direction == 1)
                        {
                            if ((i + 1 == n || used[i + 1, j] == 1))
                                direction = 2;
                            else
                                i++;
                        }

                        if (direction == 2)
                        {
                            if ((j == 0 || used[i, j - 1] == 1))
                                direction = 3;
                            else
                                j--;
                        }
                        if (direction == 3)
                        {
                            if (i == 0 || used[i - 1, j] == 1)
                            {
                                direction = 0;
                                j++;
                            }
                            else
                            {
                                i--;
                            }
                        }


                    }
                }
            }

            return list;
        }
    }
}
