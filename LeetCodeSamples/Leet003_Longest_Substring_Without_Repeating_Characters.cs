using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet003_Longest_Substring_Without_Repeating_Characters
    {
        public int Length_Of_Longest_Substring(string s)
        {
            int num = 0;
            if (!string.IsNullOrEmpty(s))
            {
                Dictionary<char, int> dict = new Dictionary<char, int>();
                int start = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    if (!dict.ContainsKey(s[i]))
                        dict.Add(s[i], i);
                    else
                    {
                        if (dict[s[i]] < start)
                            dict[s[i]] = i;
                        else
                        {
                            num = Math.Max(i - start, num);
                            start = dict[s[i]] + 1;
                            dict[s[i]] = i;
                        }
                    }
                }
                num = Math.Max(num, s.Length - start);
                if (num == 0)
                    num = s.Length;
            }
            return num;
        }
    }
}
