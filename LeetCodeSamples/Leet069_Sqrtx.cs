using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet069_Sqrtx
    {
        public static int mySqrt(int x)
        {
            if (x < 0)
                return -1;
            if (x == 0)
                return 0;
            else
            {
                double x2 = 1;
                double x1;
                do
                {
                    x1 = x2;
                    x2 = (x1 + x / x1) / 2;
                } while (Math.Abs(x2 - x1) > 0.00001);
                return (int)x2;
            }
        }

        public static int mySqrt2(int x)
        {
            if (x < 0)
                return -1;
            if (x == 0)
                return 0;
            int first = 1;
            int last = x / 2 + 1;
            int mid;
            while (first <= last)
            {
                mid = (int)((first + last) / 2.0);
                if (mid * mid == x)
                    return (int)mid;
                if ((x / mid >= mid) && ((mid + 1) > x / (mid + 1)))
                    return mid;
                else if (x / mid < mid)
                    last = mid - 1;
                else
                    first = mid + 1;
            }
            return -1;
        }
    }
}
