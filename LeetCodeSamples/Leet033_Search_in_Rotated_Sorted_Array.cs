﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet033_Search_in_Rotated_Sorted_Array
    {
        public int Search(int[] nums, int target)
        {
            if (nums != null && nums.Length > 0)
            {
                return index(nums, 0, nums.Length - 1, target);
            }
            return -1;
        }

        private int index(int[] nums, int start, int end, int target)
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
            int mid = start + (end - start) / 2;
            if (nums[mid] == target)
                return mid;
            if (nums[start] < nums[end])
            {
                if (target < nums[mid])
                    return index(nums, start, mid, target);
                else
                    return index(nums, mid, end, target);
            }
            else
            {
                if (nums[mid] < nums[end])
                {
                    if (target < nums[mid] || target > nums[end])
                        return index(nums, start, mid, target);
                    else
                        return index(nums, mid, end, target);

                }
                else
                {
                    if (target > nums[mid] || target <= nums[end])
                        return index(nums, mid, end, target);
                    else
                        return index(nums, start, mid, target);
                }
            }
            return -1;
        }
    }
}
