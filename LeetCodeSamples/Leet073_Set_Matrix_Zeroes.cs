using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet073_Set_Matrix_Zeroes
    {
        public void SetZeroes(int[,] matrix)
        {
            if (matrix != null)
            {
                int m = matrix.GetLength(0);
                int n = matrix.GetLength(1);
                int firstRow = m;
                for (int i = 0; i < m; i++)
                {
                    bool found = false;
                    for (int j = 0; j < n; j++)
                    {
                        if (matrix[i, j] == 0)
                        {
                            found = true;
                            break;
                        }
                    }
                    if (!found)
                    {
                        firstRow = i;
                        break;
                    }
                }


                int firstCol = n;
                for (int i = 0; i < n; i++)
                {
                    bool found = false;
                    for (int j = 0; j < m; j++)
                    {
                        if (matrix[j, i] == 0)
                        {
                            found = true;
                            break;
                        }
                    }
                    if (!found)
                    {
                        firstCol = i;
                        break;
                    }
                }

                if (firstRow < m && firstCol < n)
                {
                    for (int i = firstRow + 1; i < m; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            if (matrix[i, j] == 0)
                            {
                                if (j != firstCol)
                                {
                                    matrix[firstRow, j] = 0;
                                }
                                matrix[i, firstCol] = 0;
                            }
                        }
                    }
                    for (int i = 0; i < firstRow; i++)
                    {
                        for (int j = firstCol; j < n; j++)
                        {
                            if (matrix[i, j] == 0)
                            {
                                matrix[firstRow, j] = 0;
                            }
                        }
                    }
                }

                for (int i = m - 1; i >= 0; i--)
                {
                    for (int j = n - 1; j >= 0; j--)
                    {
                        if (i > firstRow && j > firstCol)
                        {
                            if (matrix[firstRow, j] == 0 || matrix[i, firstCol] == 0)
                            {
                                matrix[i, j] = 0;
                            }
                        }
                        else if (i < firstRow || j < firstCol)
                        {
                            matrix[i, j] = 0;
                        }
                    }
                }


            }
        }

        // http://blog.csdn.net/Yano_nankai/article/details/49206527

        public static void setZeroes2(int[][] matrix)
        {

            if (matrix == null || matrix.Length == 0)
            {
                return;
            }

            int mx = matrix.Length;
            int my = matrix[0].Length;

            // 两个变量，判断第一行和第一列是否有0
            bool xflag = false, yflag = false;

            // 判断第一行是否有0
            for (int i = 0; i < mx; i++)
            {
                if (matrix[i][0] == 0)
                {
                    xflag = true;
                    break;
                }
            }

            // 判断第一列是否有0
            for (int i = 0; i < my; i++)
            {
                if (matrix[0][i] == 0)
                {
                    yflag = true;
                    break;
                }
            }

            // 其它行、列是否有0
            for (int i = 1; i < mx; i++)
            {
                for (int j = 1; j < my; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        matrix[i][0] = 0;
                        matrix[0][j] = 0;
                    }
                }
            }

            // 对于第一列，为0，则将所在行变成0
            for (int i = 1; i < mx; i++)
            {
                if (matrix[i][0] == 0)
                {
                    for (int j = 0; j < my; j++)
                    {
                        matrix[i][j] = 0;
                    }
                }
            }

            // 对于第一行，为0，则将所在列变成0
            for (int i = 0; i < my; i++)
            {
                if (matrix[0][i] == 0)
                {
                    for (int j = 0; j < mx; j++)
                    {
                        matrix[j][i] = 0;
                    }
                }
            }

            // 若原来第一行中有0，则将整行置0
            if (xflag)
            {
                for (int i = 0; i < mx; i++)
                {
                    matrix[i][0] = 0;
                }
            }

            // 若原来第一列中有0，则将整列置0
            if (yflag)
            {
                for (int i = 0; i < my; i++)
                {
                    matrix[0][i] = 0;
                }
            }

        }

    }
}
