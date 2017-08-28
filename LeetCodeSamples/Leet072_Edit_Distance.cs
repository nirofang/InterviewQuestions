using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet072_Edit_Distance
    {
        // http://blog.csdn.net/yzhang6_10/article/details/50982085

        public int MinDistance(string word1, string word2)
        {
            if (String.IsNullOrEmpty(word1) && String.IsNullOrEmpty(word2))
            {
                return 0;
            }
            if (String.IsNullOrEmpty(word1))
            {
                return word2.Length;
            }
            if (String.IsNullOrEmpty(word2))
            {
                return word1.Length;
            }

            int m = word1.Length;
            int n = word2.Length;

            // 定义动态规划所需数组   
            int[,] dp = new int[m + 1, n + 1];

            // 初始化第一行元素   
            for (int i = 0; i < n + 1; i++)
            {
                dp[0, i] = i;
            }

            // 初始化第一列元素   
            for (int i = 0; i < m + 1; i++)
            {
                dp[i, 0] = i;
            }

            for (int i = 1; i < m + 1; i++)
            {
                for (int j = 1; j < n + 1; j++)
                {
                    if (word1[i - 1] == word2[j - 1])
                    {
                        dp[i, j] = dp[i - 1, j - 1];
                    }
                    else
                    {
                        //增加操作，str1a变成str2后，再加上b得到str2b  
                        //int insert = dp[i][j - 1] + 1;
                        //删除操作，str1a删除a后，再由str1变为str2b  
                        //int delet = dp[i - 1][j] + 1;
                        //替换操作，先由str1变为str2，然后str1a的a替换为b，得到str2b  
                        //int replace = dp[i - 1][j - 1] + (word1[i - 1] == word2[j - 1] ? 0 : 1);
                        //取三个最小值  
                        //dp[i][j] = min(replace, min(insert, delet));

                        dp[i, j] = 1 + Math.Min(dp[i - 1, j - 1], Math.Min(dp[i - 1, j], dp[i, j - 1]));
                    }
                }
            }

            return dp[m, n];
        }
    }
}
