﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet031_Next_Permutation
    {
        public void NextPermutation(int[] nums)
        {
            if (nums != null && nums.Length > 0)
            {
                int right = nums.Length - 2;
                while (right >= 0 && nums[right] >= nums[right + 1])
                {
                    right--;
                }
                if (right >= 0)
                {
                    int e = nums.Length - 1;
                    while (nums[e] <= nums[right])
                        e--;
                    int temp = nums[e];
                    nums[e] = nums[right];
                    nums[right] = temp;
                    switchNum(nums, right + 1, nums.Length - 1);


                }
                else
                {
                    switchNum(nums, 0, nums.Length - 1);
                }
            }
        }

        private void switchNum(int[] nums, int start, int end)
        {
            while (start < end)
            {
                int t = nums[start];
                nums[start] = nums[end];
                nums[end] = t;
                start++; end--;
            }
        }
    }
}
