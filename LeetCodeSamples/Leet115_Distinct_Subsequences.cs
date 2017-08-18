using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet115_Distinct_Subsequences
    {
        public int NumDistinct(string s, string t)
        {
            if (s == null && t == null)
            {
                return 0;
            }
            if (s == null)
                return 0;
            if (t == null)
                return s.Length;
            if (s == t)
                return 1;
            if (s.Length < t.Length)
                return 0;
            int[,] dp = new int[t.Length + 1, s.Length + 1];
            dp[0, 0] = 1;
            for (int i = 0; i <= t.Length; i++)
            {
                for (int j = 0; j <= s.Length; j++)
                {
                    if (i == 0)
                    {
                        dp[i, j] = 1;
                    }
                    else if (j == 0)
                    {
                        dp[i, j] = 0;
                    }
                    else
                    {
                        dp[i, j] = dp[i, j - 1];
                        if (s[j - 1] == t[i - 1])
                        {
                            dp[i, j] += dp[i - 1, j - 1];
                        }
                    }
                }
            }

            return dp[t.Length, s.Length];
        }
    }
}
