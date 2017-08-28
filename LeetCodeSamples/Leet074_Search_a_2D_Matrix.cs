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

        //第一种思路：从右上角开始扫描   
        public static bool searchMatrix1(List<List<int>>matrix, int target)
        {
            if (matrix.Count == 0 || matrix[0].Count == 0)
                return false;
            int i = 0;                      //控制行标志   
            int j = matrix[0].Count - 1;   //控制列标志   
            while (i < matrix.Count && j >= 0)
            {
                int x = matrix[i][j];
                if (target == x)
                    return true;
                else if (target < x)
                    --j;
                else
                    i++;
            }
            return false;
        }

        // 第二种思路：二分查找 
        public static bool searchMatrix2(List<List<int>> matrix, int target)
        {

            if (matrix.Count == 0 || matrix[0][0] > target)
                return false;
            int rows = matrix.Count;
            int cols = matrix[0].Count;
            int begin = 0;
            int end = rows - 1;
            //二分查找，查找所在行   
            while (begin <= end)
            {
                int mid = begin + (end - begin) / 2;
                if (matrix[mid][0] > target)
                    end = mid - 1;
                else if (matrix[mid][0] < target)
                    begin = mid + 1;
                else if (matrix[mid][0] == target)
                    return true;
            }
            // 记录查找所在的行   
            int row = begin - 1;
            int left = 0;
            int right = cols - 1;
            // 二分查找，查找所在的列   
            while (left <= right)
            {
                int Mid = left + (right - left) / 2;
                if (matrix[row][Mid] < target)
                    left = Mid + 1;
                else if (matrix[row][Mid] > target)
                    right = Mid - 1;
                else if (matrix[row][Mid] == target)
                    return true;
            }
            return false;
        }

    }
}
