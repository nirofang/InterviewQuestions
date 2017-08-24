using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet035_Search_Insert_Position
    {
        public int searchInsert(int[] A, int target)
        {
            if (A == null || A.Length == 0)
            {
                return 0;
            }
            int l = 0;
            int r = A.Length - 1;
            int m;
            while (l <= r)
            {
                m = 1 + (r - l) / 2;
                if (A[m] == target)
                {
                    return m;
                }
                else if (A[m] < target)
                {
                    l = m + 1;
                }
                else
                {
                    r = m - 1;
                }

            }
            return l;
        }

    }
}
