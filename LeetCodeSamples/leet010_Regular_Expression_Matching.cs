using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet010_Regular_Expression_Matching
    {
        public bool IsMatch(string s, string p)
        {
            if (p == string.Empty)
            {
                return s == string.Empty;
            }

            if (p.Length == 1)
            {
                return s.Length == 1 && (s[0] == p[0] || p[0] == '.');
            }

            if (p[1] != '*')
            {
                if (s == string.Empty)
                {
                    return false;
                }
                return (s[0] == p[0] || p[0] == '.') && IsMatch(s.Substring(1), p.Substring(1));
            }

            int index = 0;
            while (index < s.Length && (s[index] == p[0] || p[0] == '.'))
            {
                if (IsMatch(s.Substring(index), p.Substring(2)))
                {
                    return true;
                }
                index++;
            }

            return IsMatch(s.Substring(index), p.Substring(2));
        }


        public bool IsMatch2(string s, string p)
        {
            if (p == string.Empty)
            {
                return s == string.Empty;
            }

            if (p.Length == 1)
            {
                return s.Length == 1 && (s[0] == p[0] || p[0] == '.');
            }

            bool[,] match = new bool[s.Length + 1, p.Length + 1];
            match[0, 0] = true;
            for (int i = 1; i < p.Length; i++)
            {
                if (match[0, i - 1] && p[i] == '*')
                    match[0, i + 1] = true;
            }
            for (int i = 0; i < s.Length; i++)
                for (int j = 0; j < p.Length; j++)
                {
                    if (p[j] == '.' || p[j] == s[i])
                        match[i + 1, j + 1] = match[i, j];
                    else if (p[j] == '*')
                    {
                        if (p[j - 1] != s[i] && p[j - 1] != '.')
                        {
                            match[i + 1, j + 1] = match[i + 1, j - 1];
                        }
                        else
                        {
                            match[i + 1, j + 1] = (match[i + 1, j] || match[i, j + 1] || match[i + 1, j - 1]);
                        }

                    }
                }
            return match[s.Length, p.Length];
        }
    }
}
