using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet085_Maximal_Rectangle
    {

        public static int maximalRectangle(List<List<char>> matrix)
        {
            int row = matrix.Count;
            if (row == 0)
                return 0;
            int column = matrix[0].Count;
            int[,] dp = new int[row,column];
            int result = 0;
            // 初始值全部赋值为0 
            for (int i = 0; i<row; i++)
            {
                for (int j = 0; j<column; j++)
                {
                    dp[i,j] = 0;
                }
}
            // 初始化dp值 
            for (int i = 0; i<row; i++)
            {
                dp[i,column - 1] = (matrix[i][column - 1] == '1')?1:0;
            }
            for (int i = 0; i<row; i++)
            {
                for (int j = column - 2; j >= 0; j--)
                {
                    if (matrix[i][j] == '1')
                        dp[i,j] = 1 + dp[i,j + 1]; 
                }
            } 
            //以每个点作为矩形的左上角计算所得的最大矩形面积
            for (int i = 0; i<row; i++)
            {
                for (int j = 0; j<column; j++)
                {
                    //剪枝，column-j是最大宽度，row - i是最大高度
                    if ((column - j) * (row - i) <= result)
                        break;
                    int width = dp[i,j];
                    for (int k = i; k<row && width> 0; k++)
                    {
                        //剪枝，row - i是以点(i,j)为左上角的矩形的最大高度
                        if (width* (row - i) <= result)
                            break;
                        if (width > dp[k,j])
                            width = dp[k,j];
                        result = Math.Max(result, width* (k - i + 1)); 
                    } 
                }
            }
            return result; 
        }
    }
}
