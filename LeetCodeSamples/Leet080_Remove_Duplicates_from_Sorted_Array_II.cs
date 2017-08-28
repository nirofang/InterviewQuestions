using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet080_Remove_Duplicates_from_Sorted_Array_II
    {
        public static int removeDuplicates(int[] nums)
        {

            int cur = 2;
            for (int i = cur; i < nums.Length; i++)
            {
                //一个数字，最多出现2次
                if (!(nums[i] == nums[cur - 1] && nums[i] == nums[cur - 2]))
                {
                    nums[cur++] = nums[i];
                }
            }

            return Math.Min(cur, nums.Length);
        }
    }
}
