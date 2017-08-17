using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet076_Minimum_Window_Substring
    {
        public string MinWindow(string s, string t)
        {
            string result = "";
            if (!string.IsNullOrEmpty(s) && !string.IsNullOrEmpty(t))
            {
                if (s.Length < t.Length)
                {
                    return "";
                }
                Dictionary<char, int> dict = new Dictionary<char, int>();
                foreach (char c in t)
                {
                    if (dict.ContainsKey(c))
                        dict[c]++;
                    else
                        dict.Add(c, 1);
                }

                int start = -1;
                int found = 0;
                Dictionary<char, int> dict2 = new Dictionary<char, int>();
                for (int i = 0; i < s.Length; i++)
                {
                    if (dict2.ContainsKey(s[i]))
                        dict2[s[i]]++;
                    else
                        dict2.Add(s[i], 1);
                    if (dict.ContainsKey(s[i]) && dict2[s[i]] <= dict[s[i]])
                    {
                        if (start < 0)
                            start = i;
                        found++;
                    }

                    if (found == t.Length)
                    {
                        while (!dict.ContainsKey(s[start]) || dict2[s[start]] > dict[s[start]])
                        {
                            dict2[s[start]]--;
                            start++;
                        }
                        if (result == "" || i - start + 1 < result.Length)
                            result = s.Substring(start, i - start + 1);
                        found--;
                        dict2[s[start]]--;
                        start++;
                    }
                }
            }
            return result;
        }
    }
}
