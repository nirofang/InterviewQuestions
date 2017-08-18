using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet097_Interleaving_String
    {
        public bool IsInterleave(string s1, string s2, string s3)
        {
            if (string.IsNullOrEmpty(s3))
            {
                return (string.IsNullOrEmpty(s1) || string.IsNullOrEmpty(s2));
            }
            if (string.IsNullOrEmpty(s1))
            {
                return s2 == s3;
            }
            if (string.IsNullOrEmpty(s2))
            {
                return s1 == s3;
            }
            if (s1.Length + s2.Length != s3.Length)
            {
                return false;
            }

            bool[,] match = new bool[s1.Length + 1, s2.Length + 1];
            match[0, 0] = true;
            for (int i = 0; i <= s1.Length; i++)
            {
                for (int j = 0; j <= s2.Length; j++)
                {
                    if (i == 0 && j > 0)
                    {
                        match[i, j] = s3[j - 1] == s2[j - 1] && match[0, j - 1];
                    }
                    if (i > 0 && j == 0)
                    {
                        match[i, j] = s3[i - 1] == s1[i - 1] && match[i - 1, 0];
                    }
                    if (i > 0 && j > 0)
                    {
                        match[i, j] = ((s3[i + j - 1] == s1[i - 1] && match[i - 1, j]) || (s3[i + j - 1] == s2[j - 1] && match[i, j - 1]));
                    }
                }
            }
            return match[s1.Length, s2.Length];
        }
    }
}
