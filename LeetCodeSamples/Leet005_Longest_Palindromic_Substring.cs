using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet005_Longest_Palindromic_Substring
    {

        public string LongestPalindrome(string s)
        {
            if (!string.IsNullOrEmpty(s))
            {
                string result = "";
                for (int i = 0; i < s.Length; i++)
                {
                    string s1 = getPlindromic(s, i - 1, i + 1);
                    if (result.Length < s1.Length)
                        result = s1;
                    if (i < s.Length - 1 && s[i] == s[i + 1])
                    {
                        string s2 = getPlindromic(s, i - 1, i + 2);
                        if (result.Length < s2.Length)
                            result = s2;
                    }
                }
                return result;
            }
            else
                return s;
        }

        private string getPlindromic(string s, int left, int right)
        {
            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                left--;
                right++;
            }
            return s.Substring(left + 1, right - left - 1);
        }
    }
}
