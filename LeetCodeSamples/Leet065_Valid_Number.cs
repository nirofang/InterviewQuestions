using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet065_Valid_Number
    {
        public bool IsNumber(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return false;
            }

            s = s.Trim();
            if (s == "")
            {
                return false;
            }
            int dot = -1;
            int ee = -1;
            int eeLength = 0;
            int dotLength = 0;
            if (s[0] == '+' || s[0] == '-')
            {
                s = s.Substring(1);
            }

            if (s.Length == 0)
            {
                return false;
            }

            int i = 0;
            while (i < s.Length)
            {
                char c = s[i];
                if (c == '.')
                {
                    if (dot == -1 && ee == -1)
                    {
                        dot = i;
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (c == 'e')
                {
                    if (ee == -1)
                    {
                        ee = i;
                        if (i < s.Length - 1)
                        {
                            if (s[i + 1] == '+' || s[i + 1] == '-')
                            {
                                i++;
                            }
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    if (0 <= c - '0' && 9 >= c - '0')
                    {
                        if (ee != -1)
                        {
                            eeLength++;
                        }
                        if (dot != -1 && ee == -1)
                        {
                            dotLength++;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                i++;
            }

            if (ee > 0 && eeLength == 0)
            {
                return false;
            }

            if (dot == 0 && dotLength == 0)
            {
                return false;
            }

            if (ee == 0)
            {
                return false;
            }

            return true;
        }
    }
}
