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

        public static string minWindow(string s, string t)
        {
            int slen = s.Length;
            int tlen = t.Length;
            Queue<int> Q = new Queue<int>();
            int[] srccnt = new int[256];    //= { 0 };      //统计T中每个字母的个数   
            int[] foundcnt = new int[256];  //= { 0 };    //当前找到T中每个字母的个数   
            for (int i = 0; i < tlen; i++)
                srccnt[t[i]]++;
            int hasfound = 0;           //已经找到的字母数目  
            int winstart = -1;
            int winend = slen;
            // 遍历字符串S   
            for (int i = 0; i < slen; i++)
            {
                if (srccnt[s[i]] != 0)
                {
                    Q.Enqueue(i);
                    foundcnt[s[i]]++;
                    // 记录截止目前，找到子串T中的字母个数   
                    if (foundcnt[s[i]] <= srccnt[s[i]])
                        hasfound++;
                    // 当找到tlen时，进行收缩   
                    if (hasfound == tlen)
                    {
                        //找到一个满足的窗口  
                        int k;
                        do
                        {
                            //缩减窗口到最小  
                            k = Q.Peek();
                            Q.Dequeue();
                            foundcnt[s[k]]--;
                        } while (srccnt[s[k]] <= foundcnt[s[k]]);
                        // 判断当前情况下子串长度是否为更小，更小则更新，否则不变   
                        if (winend - winstart > i - k)
                        {
                            winstart = k;
                            winend = i;
                        }
                        hasfound--;
                    }
                }
            }
            return winstart != -1 ? s.Substring(winstart, winend - winstart + 1) : "";
        }

    }
}
