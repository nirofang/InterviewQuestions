using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet091_Decode_Ways
    {
        public int NumDecodings(string s)
        {
            if (string.IsNullOrEmpty(s) || s[0] == '0')
            {
                return 0;
            }
            int[] dp = new int[s.Length + 1];
            dp[0] = 1;
            if (isValid(s.Substring(0, 1)))
                dp[1] = 1;
            else
                dp[1] = 0;
            for (int i = 2; i <= s.Length; i++)
            {
                if (isValid(s.Substring(i - 1, 1)))
                    dp[i] += dp[i - 1];
                if (isValid(s.Substring(i - 2, 2)))
                    dp[i] += dp[i - 2];
            }

            return dp[s.Length];
        }

        private bool isValid(string s)
        {
            if (s[0] == '0')
            {
                return false;
            }

            int v = int.Parse(s);
            return v >= 1 && v <= 26;
        }
    }
}
