using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet049_Group_Anagrams
    {
        // http://www.cnblogs.com/grandyang/p/4385822.html

        public static List<List<string>> groupAnagrams(List<string> strs)
        {
            List<List<string>> res = new List<List<string>>();
            Dictionary<string, List<string>> m = 
                new Dictionary<string, List<string>>();
            foreach (string str in strs)
            {
                string t = str;
                //sort(t.begin(), t.end()); c++
                char[] arr = t.ToCharArray();
                Array.Sort(arr);
                t = new string(arr);

                if (!m.ContainsKey(t))
                {
                    m[t] = new List<string>();
                }
                m[t].Add(str);
            }
            foreach (var a in m)
            {
                res.Add(a.Value);
            }
            return res;
        }


        public static List<List<string>> groupAnagrams2(List<string> strs)
        {
            List<List<string>> res = new List<List<string>>();
            Dictionary<string, List<string>> m =
                new Dictionary<string, List<string>>();
            foreach (string str in strs)
            {
                // add 26 char
                int[] cnt = new int[26];
                foreach (char c in str)
                {
                    cnt[c - 'a']++;
                }
                StringBuilder sb = new StringBuilder();

                foreach (int d in cnt)
                {
                    sb.Append(d).Append("/");
                }
                string t = sb.ToString();

                if (!m.ContainsKey(t))
                {
                    m[t] = new List<string>();
                }
                m[t].Add(str);
            }
            foreach (var a in m)
            {
                res.Add(a.Value);
            }
            return res;
        }
    }
}
