using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet055_Jump_Game
    {
        public bool CanJump(int[] nums)
        {
            int last = 0, curr = 0;
            if (nums != null && nums.Length > 0)
            {
                if (nums.Length == 1)
                    return true;

                for (int i = 0; i < nums.Length; i++)
                {
                    if (i > last)
                    {
                        last = curr;
                        if (i > curr)
                            return false;
                    }
                    curr = Math.Max(curr, i + nums[i]);
                    if (curr >= nums.Length - 1)
                        return true;
                }
            }

            return false;
        }
    }
}
