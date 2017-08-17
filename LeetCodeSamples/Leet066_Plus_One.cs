using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet066_Plus_One
    {
        public int[] PlusOne(int[] digits)
        {
            if (digits == null || digits.Length == 0)
            {
                return new int[] { 1 };
            }
            List<int> list = new List<int>();
            int carry = 1;
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                list.Insert(0, (digits[i] + carry) % 10);
                carry = (digits[i] + carry) / 10;
            }
            if (carry > 0)
            {
                list.Insert(0, carry);
            }
            return list.ToArray();
        }
    }
}
