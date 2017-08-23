using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet029_Divide_Two_Integers
    {
        public int divide(int dividend, int divisior)
        {
            if (divisior == 0)
            {
                return int.MaxValue;
            }
            if (dividend == 0)
            {
                return 0;
            }
            if (divisior == 1)
            {
                return dividend;
            }
            if (divisior == -1)
            {
                return -dividend;
            }

            bool neg = (dividend > 0 && divisior < 0) || (dividend < 0 && divisior > 0);
            long ldividend = Math.Abs(dividend);
            long ldivisor = Math.Abs(divisior);
            int res = 0;
            for (int bit = sizeof(int) * 8 - 1; bit >= 0 && ldividend >= ldivisor; bit--)
            {
                if (ldividend >= (ldivisor << bit))
                {
                    res |= 1 << bit;
                    ldividend -= ldivisor << bit;
                }
            }
            return neg ? -res : res;
        }
    }
}
