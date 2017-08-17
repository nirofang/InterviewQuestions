using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet027_Remove_Element
    {
        public int RemoveElement(int[] nums, int val)
        {
            if (nums != null && nums.Length > 0)
            {
                int i = 0;
                while (i < nums.Length && nums[i] != val)
                {
                    i++;
                }
                int j = i + 1;
                while (j < nums.Length)
                {
                    while (j < nums.Length && nums[j] == val)
                        j++;
                    if (j < nums.Length)
                    {
                        nums[i] = nums[j];
                        i++;
                        j++;
                    }
                }
                return i;
            }
            return 0;
        }

    }
}
