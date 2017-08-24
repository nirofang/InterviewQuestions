using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet038_Count_and_Say
    {
        public string countAndSay(int n)
        {
            string res = "1";
            while(--n>0)
            {
                StringBuilder sb = new StringBuilder();
                char[] pre = res.ToCharArray();
                for(int i=0; i<pre.Length; i++)
                {
                    int count = 1;
                    while(i+1< pre.Length && pre[i] == pre[i+1])
                    {
                        count++;
                        i++;
                    }
                    sb.Append(count).Append(pre[i]);
                }
                res = sb.ToString();
            }
            return res;
        }
    }
}
