using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{

    public class Leet093_Restore_IP_Addresses
    {
        IList<string> results = new List<string>();

        public IList<string> RestoreIpAddresses(string s)
        {
            if (!string.IsNullOrEmpty(s) && s.Length >= 4 && s.Length <= 12)
            {
                int length = s.Length;
                fillList(s, 0, 0, "");
            }
            return results;
        }

        void fillList(string s, int dotNum, int index, string temp)
        {
            if (dotNum == 4)
            {
                results.Add(temp.Substring(1));
            }
            else
            {
                if (s.Length - index >= (4 - dotNum))
                {
                    for (int i = 1; i <= 3; i++)
                    {
                        if (index + i <= s.Length && (s.Length - index - i >= 3 - dotNum) && (s.Length - index - i <= 3 * (3 - dotNum)))
                        {
                            if (dotNum < 3 || (dotNum == 3 && index + i == s.Length))
                            {
                                if ((i == 1 || (i > 1 && s.Substring(index, 1) != "0")) && isValid(s.Substring(index, i)))
                                {
                                    fillList(s, dotNum + 1, index + i, temp + "." + s.Substring(index, i));
                                }
                            }
                        }
                    }
                }
            }
        }
        private bool isValid(string s)
        {
            int v = int.Parse(s);
            return v < 256;
        }
    }
}
