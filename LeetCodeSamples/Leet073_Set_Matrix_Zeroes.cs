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
    }
}
