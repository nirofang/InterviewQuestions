using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet043_Multiply_String
    {
        public string multiplyString(string num1, string num2)
        {
            if (num1 == null || num2 == null)
            {
                return "";
            }
            if (num1.Equals("0") || num2.Equals("0"))
            {
                return "0";
            }
            char[] c1 = num1.ToCharArray();
            char[] c2 = num2.ToCharArray();
            int m = c1.Length;
            int n = c2.Length;

            int[] res = new int[m + n]; //max posible length

            for (int i = m - 1; i >= 0; i--)
            {
                for (int j = n - 1; j >= 0; j--)
                {
                    res[m + n - i - j - 2] += (c1[i] - '0') * (c2[j] - '0');
                    res[m + n - i - j - 1] += res[m + n - i - j - 2] / 10;
                    res[m + n - i - j - 2] %= 10;
                }
            }

            // build ans string
            StringBuilder ans = new StringBuilder();
            for (int i = m + n - 1; i >= 0; i--)
            {
                if (res[i]!=0)
                {
                    for(int j=i; j>=0; j--)
                    {
                        ans.Append(res[j]);
                    }
                    return ans.ToString();
                }
                
            }
            return "0";
        }
    }
}
