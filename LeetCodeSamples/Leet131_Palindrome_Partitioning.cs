using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet131_Palindrome_Partitioning
    {
        public static IList<IList<string>> Partition(string s)
        {
            IList<IList<string>> res = new List<IList<string>>();
            List<string> temp = new List<string>();
            dfs(s, temp, res);

            return res;
        }

        static void dfs(string s, List<string> temp, IList<IList<string>> res)
        {
            if (s.Length == 0)
            {
                res.Add(new List<string>(temp));
                return;
            }
            for (int i = 1; i <= s.Length; i++)
            {
                string sub = s.Substring(0, i);
                if (isPal(sub))
                {
                    temp.Add(sub);
                    string nextsub = s.Substring(i, s.Length - i);
                    dfs(nextsub, temp, res);
                    temp.RemoveAt(temp.Count - 1);
                }
            }

        }

        static bool isPal(string s)
        {
            int l = 0;
            int r = s.Length - 1;
            while (l <= r)
            {
                if (s[l] != s[r])
                {
                    return false;
                }
                l++;
                r--;
            }
            return true;
        }
    }
}
