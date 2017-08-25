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

        public List<int> spiralOrder2(int[][] matrix)
        {
            List<int> res = new List<int>();
            if (matrix.Length == 0) return res;
            int m = matrix.Length, n = matrix[0].Length;
            // 计算圈数
            int lvl = (Math.Min(m, n) + 1) / 2;
            for (int i = 0; i < lvl; i++)
            {
                // 计算相对应的该圈最后一行
                int lastRow = m - i - 1;
                // 计算相对应的该圈最后一列
                int lastCol = n - i - 1;
                // 如果该圈第一行就是最后一行，说明只剩下一行
                if (i == lastRow)
                {
                    for (int j = i; j <= lastCol; j++)
                    {
                        res.Add(matrix[i][j]);
                    }
                    // 如果该圈第一列就是最后一列，说明只剩下一列
                }
                else if (i == lastCol)
                {
                    for (int j = i; j <= lastRow; j++)
                    {
                        res.Add(matrix[j][i]);
                    }
                }
                else
                {
                    // 第一行
                    for (int j = i; j < lastCol; j++)
                    {
                        res.Add(matrix[i][j]);
                    }
                    // 最后一列
                    for (int j = i; j < lastRow; j++)
                    {
                        res.Add(matrix[j][lastCol]);
                    }
                    // 最后一行
                    for (int j = lastCol; j > i; j--)
                    {
                        res.Add(matrix[lastRow][j]);
                    }
                    // 第一列
                    for (int j = lastRow; j > i; j--)
                    {
                        res.Add(matrix[j][i]);
                    }
                }
            }
            return res;
        }

    }
}
