using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet006_ZigZag_Conversion
    {
        public string ZigZag_Convert(string s, int numRows)
        {
            if (s == null || s.Length == 0 || numRows == 1)
            {
                return s;
            }

            if (numRows >= s.Length)
            {
                return s;
            }

            Dictionary<int, string> dict = new Dictionary<int, string>();
            int i = 0;
            int r = 0;
            int direct = 0;
            while (i < s.Length)
            {
                if (dict.ContainsKey(r))
                {
                    dict[r] += s.Substring(i, 1);
                }
                else
                {
                    dict.Add(r, s.Substring(i, 1));
                }

                i++;

                if (r == numRows - 1)
                {
                    direct = 1;
                }
                if (r == 0)
                {
                    direct = 0;
                }

                if (direct == 0)
                {
                    r++;
                }
                else
                {
                    r--;
                }
            }
            string result = "";
            for (int k = 0; k < numRows; k++)
            {
                result += dict[k];
            }
            return result;
        }

        public string ZigZag_Convert_Own(string s, int numRows)
        {
            StringBuilder[] zig = new StringBuilder[numRows];
            for (int k = 0; k < numRows; k++)
            {
                zig[k] = new StringBuilder();
            }
            int i = 0;
            while (i < s.Length)
            {
                for (int j = 0; j < numRows && i< s.Length; j++)
                {
                    zig[j].Append(s[i]);
                    i++;
                }

                for (int j = numRows - 2; j > 0 && i < s.Length; j--)
                {
                    zig[j].Append(s[i]);
                    i++;
                }
            }

            for (int k = 1; k < numRows; k++)
            {
                zig[0].Append(zig[k].ToString());
            }
            return zig[0].ToString();
        }
    }
}
