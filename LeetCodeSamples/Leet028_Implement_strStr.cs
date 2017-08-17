using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet028_Implement_strStr
    {
        public int StrStr_Default(string haystack, string needle)
        {
            if (haystack == null || needle == null || haystack.Length < needle.Length)
            {
                return -1;
            }

            if (haystack == string.Empty && needle == string.Empty)
            {
                return 0;
            }

            if (needle == string.Empty)
            {
                return 0;
            }

            for (int i = 0; i <= haystack.Length - needle.Length; i++)
            {
                if (haystack[i] == needle[0])
                {
                    bool match = true;
                    for (int j = 1; j < needle.Length; j++)
                    {
                        if (haystack[i + j] != needle[j])
                        {
                            match = false;
                            break;
                        }
                    }
                    if (match)
                    {
                        return i;
                    }
                }
            }

            return -1;

        }
    }
}
