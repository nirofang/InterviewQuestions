using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet074_Search_a_2D_Matrix
    {
        public bool SearchMatrix(int[,] matrix, int target)
        {
            if (matrix != null)
            {
                int m = matrix.GetLength(0);
                int n = matrix.GetLength(1);
                if (m == 0 || n == 0)
                    return false;

                if (target < matrix[0, 0])
                    return false;

                int i = 0;
                while (i < m)
                {
                    if (target >= matrix[i, 0])
                        i++;
                    else
                        break;
                }
                int j = 0;
                if (i > 0)
                    i--;
                while (j < n)
                {
                    if (target == matrix[i, j])
                        return true;
                    if (target > matrix[i, j])
                        j++;
                    else
                    {
                        return false;
                    }

                }
                return false;
            }

            return false;
        }
    }
}
