using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet048_Rotate_Image
    {
        public static void rotate(List<List<int>> matrix)
        {
            if (matrix.Count == 0)
            {
                return;
            }
            int n = matrix.Count, tmp;
            for (int i = 0; i < n / 2; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    tmp = matrix[i][j];
                    matrix[i][j] = matrix[n - 1 - i][j];
                    matrix[n - 1 - i][j] = tmp;
                }
            }
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < i; ++j)
                {
                    tmp = matrix[i][j];
                    matrix[i][j] = matrix[j][i];
                    matrix[j][i] = tmp;
                }
            }
            return;
        }

    }
}
