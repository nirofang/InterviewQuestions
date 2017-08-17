﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet034_Search_for_a_Range
    {
        public int[] SearchRange(int[] nums, int target)
        {
            int[] results = new int[2] { -1, -1 };
            if (nums != null && nums.Length > 0)
            {
                int index = find(nums, 0, nums.Length - 1, target);
                if (index >= 0)
                {
                    int left = index;
                    int right = index;
                    while (left - 1 >= 0 && nums[left - 1] == nums[index])
                    {
                        left--;
                    }
                    while (right + 1 < nums.Length && nums[right + 1] == nums[index])
                        right++;
                    results[0] = left;
                    results[1] = right;
                }
            }
            return results;
        }

        private int find(int[] nums, int start, int end, int target)
        {
            if (start == end || start == end - 1)
            {
                if (nums[start] == target)
                    return start;
                else if (nums[end] == target)
                    return end;
                else
                    return -1;
            }
            else
            {
                int mid = start + (end - start) / 2;
                if (nums[mid] == target)
                    return mid;
                else if (nums[start] <= target && nums[mid] > target)
                    return find(nums, start, mid, target);
                else
                    return find(nums, mid, end, target);
            }
        }
    }
}
