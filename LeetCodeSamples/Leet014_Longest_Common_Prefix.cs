using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet014_Longest_Common_Prefix
    {
        public string LongestCommonPrefix(string[] strs)
        {
            int i = 1;
            string longestStr = "";
            if (strs == null || strs.Length == 0)
            {
                return "";
            }

            if (strs.Length == 1)
            {
                return strs[0];
            }

            while (i <= strs[0].Length)
            {
                string temp = strs[0].Substring(0, i);
                for (int j = 1; j < strs.Length; j++)
                {
                    if (i > strs[j].Length)
                    {
                        return longestStr;
                    }

                    if (!strs[j].StartsWith(temp))
                    {
                        return longestStr;
                    }
                }
                longestStr = temp;
                i++;
            }

            return longestStr;
        }
    }
}
