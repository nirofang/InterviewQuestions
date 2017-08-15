using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet009_Palindrome_Number
    {
        public bool isPalindrom(int num)
        {
            if (num < 0) return false;

            int div = 1;
            while (num / div > 10) div *= 10;

            while (num != 0)
            {
                int l = num / div;
                int r = num % 10;
                if (l != r)
                {
                    return false;
                }

                num = (num % div) / 10;
                div /= 100;

            }
            return true;
        }
    }
}
