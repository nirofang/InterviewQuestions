using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet081_Search_in_Rotated_Sorted_Array_II
    {
        public bool Search(int[] nums, int target)
        {
            if (nums != null && nums.Length != 0)
            {
                return search(nums, 0, nums.Length - 1, target);
            }
            return false;
        }

        private bool search(int[] nums, int start, int end, int target)
        {
            while (start < end && nums[start + 1] == nums[start])
            {
                start++;
            }
            while (start < end && nums[end - 1] == nums[end])
            {
                end--;
            }
            if (start < end && nums[start] == nums[end])
                end--;

            if (start == end || start == end - 1)
            {
                return target == nums[start] || target == nums[end];
            }

            int mid = start + (end - start) / 2;
            if (target == nums[mid])
            {
                return true;
            }
            else
            {
                if (nums[mid] < target && nums[end] >= target)
                {
                    return search(nums, mid, end, target);
                }
                else if (nums[start] <= target && nums[mid] > target)
                {
                    return search(nums, start, mid, target);
                }
                else if (nums[mid] > nums[end] && (target > nums[mid] || target <= nums[end]))
                {
                    return search(nums, mid, end, target);
                }
                else
                    return search(nums, start, mid, target);
            }
        }

        public static bool search(int[] nums, int target)
        {

            int left = 0, right = nums.Length - 1;

            while (left <= right)
            {

                int mid = (left + right) / 2;

                if (nums[mid] == target)
                    return true;

                if (nums[left] < nums[mid])
                {
                    if (target <= nums[mid] && target >= nums[left])
                        right = mid - 1;
                    else
                        left = mid + 1;
                }
                else if (nums[left] > nums[mid])
                {
                    if (target >= nums[left] || target <= nums[mid])
                        right = mid - 1;
                    else
                        left = mid + 1;
                }
                else
                    left++;
            }

            return false;
        }

    }
}
