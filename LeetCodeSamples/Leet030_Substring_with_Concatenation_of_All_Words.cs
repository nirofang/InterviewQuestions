using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet030_Substring_with_Concatenation_of_All_Words
    {
        public IList<int> FindSubstring(string s, string[] words)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach (string word in words)
            {
                if (dict.ContainsKey(word))
                    dict[word]++;
                else
                    dict.Add(word, 1);
            }

            IList<int> list = new List<int>();
            if (words != null && words.Length > 0)
            {
                int m = s.Length;
                int n = words[0].Length;
                int j = words.Length;

                for (int i = 0; i <= m - n * j; i++)
                {
                    int count = 0;
                    Dictionary<string, int> dict2 = new Dictionary<string, int>();
                    for (int k = 0; k < j; k++)
                    {
                        string w = s.Substring(i + k * n, n);
                        if (!dict.ContainsKey(w))
                            break;
                        if (dict2.ContainsKey(w))
                            dict2[w]++;
                        else
                            dict2.Add(w, 1);
                        if (dict2[w] > dict[w])
                            break;
                        count++;
                    }
                    //if (count == j)
                    if (count > 0)
                        list.Add(i);
                }
            }

            return list;
        }
    }
}
