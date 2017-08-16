using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet058_Length_of_Last_Word
    {
        public int LengthOfLastWord(string s)
        {
            if (!string.IsNullOrEmpty(s))
            {
                int end = s.Length - 1;
                while (end >= 0 && s[end] == ' ')
                    end--;
                if (end < 0)
                    return 0;

                int start = end;
                while (start >= 0)
                {
                    if (s[start] != ' ')
                        start--;
                    else
                        break;
                }
                return end - start;
            }
            else
                return 0;
        }
    }
}
