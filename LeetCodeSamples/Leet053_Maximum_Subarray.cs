using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet053_Maximum_Subarray
    {
        public int MaxSubArray(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return 0;
            }

            int[] max = new int[nums.Length];

            max[0] = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                max[i] = Math.Max(max[i - 1] + nums[i], nums[i]);
            }

            int result = int.MinValue;

            foreach (int m in max)
            {
                if (result < m)
                    result = m;
            }
            return result;
        }

        public int maxSubArray2(int[] A)
        {
            if (A == null || A.Length == 0)
            {
                return 0;
            }
            if(A.Length ==1)
            {
                return A[0];
            }
            
            int sum = A[A.Length - 1];
            int maxSum = sum;

            for (int i = A.Length - 2; i >= 0; i--)
            {
                sum = Math.Max(A[i], sum + A[i]);
                maxSum = Math.Max(maxSum, sum);
            }

            return maxSum;
        }

    }
}
