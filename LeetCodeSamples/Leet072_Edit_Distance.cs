using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet072_Edit_Distance
    {
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
            int[,] dp = new int[m + 1, n + 1];
            for (int i = 0; i < n + 1; i++)
            {
                dp[0, i] = i;
            }
            for (int i = 0; i < m + 1; i++)
            {
                dp[i, 0] = i;
            }

            for (int i = 1; i < m + 1; i++)
            {
                for (int k = 1; k < n + 1; k++)
                {
                    if (word1[i - 1] == word2[k - 1])
                    {
                        dp[i, k] = dp[i - 1, k - 1];
                    }
                    else
                    {
                        dp[i, k] = 1 + Math.Min(dp[i - 1, k - 1], Math.Min(dp[i - 1, k], dp[i, k - 1]));
                    }
                }
            }

            return dp[m, n];
        }
    }
}
