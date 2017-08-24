using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet044_Wildcard_Matching
    {
        static bool matchChar(char c, char p)
        {
            return (p == '?' || p == c);
        }

        public static bool isMatch(String s, String p)
        {
            if (s == null || p == null)
            {
                return false;
            }

            int indexS = 0;
            int indexP = 0;

            int lenS = s.Length;
            int lenP = p.Length;

            int preS = 0;
            int preP = 0;

            bool back = false;

            while (indexS < lenS)
            {
                if (indexP < lenP && matchChar(s[indexS], p[indexP]))
                {
                    indexS++;
                    indexP++;
                }
                else if (indexP < lenP && p[indexP] == '*')
                {
                    while (indexP < lenP && p[indexP] == '*')
                    {
                        indexP++;
                    }

                    //P的最后一个是 *，表示可以匹配任何字符串
                    if (indexP == lenP)
                    {
                        return true;
                    }

                    // 记录下这个匹配位置。
                    back = true;
                    preS = indexS;
                    preP = indexP;
                }
                else if (back)
                {
                    indexS = ++preS;
                    indexP = preP;
                }
                else
                {
                    return false;
                }
            }

            // 跳过末尾的所有的*.
            while (indexP < lenP && p[indexP] == '*')
            {
                indexP++;
            }

            if (indexS == lenS && indexP == lenP)
            {
                return true;
            }

            return false;
        }


        public static bool isMatch2(String s, String p)
        {
            // 2030.
            if (s == null || p == null)
            {
                return false;
            }

            int indexS = 0;
            int indexP = 0;

            int lenS = s.Length;
            int lenP = p.Length;

            int preP = -1;
            int preS = -1;

            while (indexS < lenS)
            {
                if (indexP < lenP && matchChar(p[indexP], s[indexS]))
                {
                    indexP++;
                    indexS++;
                }
                else if (indexP < lenP && p[indexP] == '*')
                {
                    preS = indexS;
                    preP = indexP;

                    // Move to the next character of P.
                    indexP++;
                }
                else if (preP != -1)
                {
                    indexP = preP;
                    indexP++;

                    preS++;
                    indexS = preS;
                }
                else
                {
                    return false;
                }
            }

            while (indexP < lenP)
            {
                if (p[indexP] != '*')
                {
                    return false;
                }
                indexP++;
            }

            return true;
        }

    }
}
