using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet050_Pow_x_n
    {

        public double pow_Default(double x, int n)
        {
            if (n == 0)
            {
                return 1;
            }
            if (n < 0)
            {
                n = -n;
                x = 1 / x;
            }
            double res = 1;
            for (double f =x; n>0; n>>=1)
            {
                if (n % 2 == 1) res *= f;
                f = f * f;
            }
            return res;

        }


        public double pow_Self(double x, int n)
        {
            if (n == 0)
            {
                return 1;
            }
            if (n < 0)
            {
                n = -n;
                x = 1 / x;
            }
            double res = 1;
            for (int i = 0; i< n; i++)
            {
                res *= x;
            }
            return res;

        }
    }
}
