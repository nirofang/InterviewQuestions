using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet067_Add_Binary
    {
        public string AddBinary(string a, string b)
        {
            if (!string.IsNullOrEmpty(a) && !string.IsNullOrEmpty(b))
            {
                if (a.Length < b.Length)
                    return AddBinary(b, a);

                string result = "";
                int i = a.Length - 1, j = b.Length - 1;
                int carry = 0;
                while (i >= 0 && j >= 0)
                {
                    int n1 = a[i] - '0';
                    int n2 = b[j] - '0';
                    int sum = (n1 + n2 + carry) % 2;
                    carry = (n1 + n2 + carry) / 2;
                    result = sum.ToString() + result;
                    i--;
                    j--;
                }
                while (i >= 0)
                {
                    int n1 = a[i] - '0';
                    int sum = (n1 + carry) % 2;
                    carry = (n1 + carry) / 2;
                    result = sum.ToString() + result;
                    i--;
                }

                if (carry > 0)
                    result = "1" + result;
                return result;
            }
            else
            {
                if (string.IsNullOrEmpty(a))
                    return b;
                if (string.IsNullOrEmpty(b))
                    return a;
            }
            return "";
        }
    }
}
