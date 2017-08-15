using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet008_String_to_Integer_atoi
    {
        public int MyAtoi(string str)
        {
            if (!string.IsNullOrEmpty(str) && str.Length > 0)
            {
                str = str.Trim();
                bool isNeg = false;
                if (str[0] == '-')
                {
                    str = str.Substring(1);
                    isNeg = true;
                }
                else if (str[0] == '+')
                    str = str.Substring(1);

                long num = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    int n = str[i] - '0';
                    if (n < 0 || n > 9)
                        break;
                    else
                        num = num * 10 + n;
                    if (num > int.MaxValue)
                        break;
                }
                if (isNeg)
                    num = num * (-1);
                if (num < int.MinValue)
                    return int.MinValue;
                else if (num > int.MaxValue)
                    return int.MaxValue;
                else
                    return (int)num;
            }
            else
                return 0;
        }
    }
}
