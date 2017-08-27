using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet070_Climbing_Stairs
    {
        public static int climbStairs(int n)
        {
            int f1 = 1;
            int f2 = 1;
            int f3 = 0;
            if (n < 0) return 0;
            if (n < 2) return 1;

            for (int i = 2; i <= n; i++)
            {
                f3 = f1 + f2;
                f1 = f2;
                f2 = f3;
            }
            return f3;
        }

        public static int climbStairs2(int n)
        {
            int[] temp = new int[3];
            temp[0] = 1;
            temp[1] = 1;
            for (int ii = 2; ii <= n; ii++)
            {
                temp[ii % 3] = temp[(ii - 1) % 3] + temp[(ii - 2) % 3];
            }
            return temp[n % 3];
        }
    }
}
