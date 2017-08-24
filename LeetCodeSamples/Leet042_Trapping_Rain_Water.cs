using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet042_Trapping_Rain_Water
    {
        public int trapWater(int[] A)
        {
            if (A == null || A.Length == 0)
            {
                return 0;
            }

            int l = 0;
            int r = A.Length - 1;
            int level = 0;
            int all = 0;
            int block = 0;
            while(l<=r)
            {
                int curlevel = Math.Min(A[l], A[r]);
                if (curlevel > level)
                {
                    all += (curlevel - level) * (r - l + 1);
                    level = curlevel;
                }
                if (A[l] < A[r])
                {
                    block += A[l++];
                }
                else
                {
                    block += A[r--];
                }
            }
            return all - block;
        }
    }
}
