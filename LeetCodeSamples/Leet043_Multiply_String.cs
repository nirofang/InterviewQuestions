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
                    // 乘积=乘数1的第i位 * 乘数的第j位+ 进位carry+ 数组当前位
                    res[m + n - i - j - 2] += (c1[i] - '0') * (c2[j] - '0');
                    // 进位=乘积/10
                    res[m + n - i - j - 1] += res[m + n - i - j - 2] / 10;
                    // 数组当前位最终 = 乘积 % 10
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

        public String multiplyString_Web(String num1, String num2)
        {
            if (num1.Equals("0") || num2.Equals("0")) return "0";
            int len1 = num1.Length;
            int len2 = num2.Length;
            int product, carry, i, j;
            int[] num = new int[len1 + len2];
            for (i = len1 - 1; i >= 0; i--)
            {
                carry = 0;
                for (j = len2 - 1; j >= 0; j--)
                {
                    product = carry + (int)(num1[i] - '0') * (int)(num2[j] - '0') + num[i + j + 1];
                    num[i + j + 1] = product % 10;
                    carry = product / 10;
                }
                num[i + j + 1] = carry;
            }
            i = 0;
            while (i < len1 + len2 && num[i] == 0)
            {
                i++;
            }
            StringBuilder sb = new StringBuilder();
            while (i < len1 + len2)
            {
                sb.Append(num[i]);
                i++;
            }

            return sb.ToString();
        }
    }
}
