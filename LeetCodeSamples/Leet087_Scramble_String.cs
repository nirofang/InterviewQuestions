using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet087_Scramble_String
    {
        public bool IsScramble(string s1, string s2)
        {
            if (s1 == null && s2 == null)
            {
                return true;
            }
            if (s1 == null || s2 == null)
            {
                return false;
            }
            if (s1.Length != s2.Length)
            {
                return false;
            }
            if (s1 == s2)
            {
                return true;
            }

            int[] a = new int[26];
            for (int i = 0; i < s1.Length; i++)
            {
                a[s1[i] - 'a']++;
                a[s2[i] - 'a']--;
            }
            for (int i = 0; i < 26; i++)
            {
                if (a[i] != 0)
                    return false;
            }
            for (int i = 1; i < s1.Length; i++)
            {
                if (IsScramble(s1.Substring(0, i), s2.Substring(0, i)) && IsScramble(s1.Substring(i), s2.Substring(i)))
                {
                    return true;
                }
                if (IsScramble(s1.Substring(0, i), s2.Substring(s2.Length - i)) && IsScramble(s1.Substring(i), s2.Substring(0, s2.Length - i)))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
