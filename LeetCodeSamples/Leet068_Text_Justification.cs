using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet068_Text_Justification
    {
        public IList<string> FullJustify(string[] words, int maxWidth)
        {
            IList<string> list = new List<string>();
            if (words == null || words.Length == 0)
            {
                return list;
            }
            int count = 0;
            int last = 0;
            for (int i = 0; i < words.Length; i++)
            {
                if (count + (i - last) + words[i].Length > maxWidth)
                {
                    int spaces = 0;
                    int extraSpaces = 0;

                    if (i - last - 1 > 0)
                    {
                        spaces = (maxWidth - count) / (i - last - 1);
                        extraSpaces = (maxWidth - count) % (i - last - 1);
                    }
                    string s = "";
                    for (int j = last; j < i; j++)
                    {
                        s += words[j];
                        if (j < i - 1)
                        {
                            s += new string(' ', spaces);
                        }
                        if (extraSpaces > 0)
                        {
                            s += " ";
                            extraSpaces--;
                        }
                    }
                    for (int j = s.Length; j < maxWidth; j++)
                    {
                        s += " ";
                    }

                    list.Add(s);
                    count = words[i].Length;
                    last = i;
                }
                else
                {
                    count += words[i].Length;
                }
            }

            string s1 = "";
            for (int i = last; i < words.Length; i++)
            {
                s1 += words[i];
                if (s1.Length < maxWidth)
                {
                    s1 += " ";
                }
            }
            for (int j = s1.Length; j < maxWidth; j++)
            {
                s1 += " ";
            }

            list.Add(s1);

            return list;
        }
    }
}
