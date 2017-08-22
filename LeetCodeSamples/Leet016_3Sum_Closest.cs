using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet016_3Sum_Closest
    {

        public int ThreeSumClosest(int[] nums, int target)
        {
            if (nums == null || nums.Length < 3)
            {
                return 0;
            }
            Array.Sort(nums);
            int i = 0;
            int closest = int.MaxValue;
            while (i < nums.Length - 2)
            {
                int j = i + 1;
                int k = nums.Length - 1;
                while (j < k)
                {
                    int sum = nums[i] + nums[j] + nums[k];
                    if (sum == target)
                    {
                        return target;
                    }
                    else
                    {
                        if (closest == int.MaxValue || Math.Abs(closest - target) > Math.Abs(sum - target))
                        {
                            closest = sum;
                        }
                    }
                    if (sum < target)
                    {
                        while (j < k && nums[j + 1] == nums[j])
                        {
                            j++;
                        }
                        j++;
                    }
                    else
                    {
                        while (j < k && nums[k - 1] == nums[k])
                        {
                            k--;
                        }
                        k--;
                    }
                }
                while (i < nums.Length - 2 && nums[i + 1] == nums[i])
                {
                    i++;
                }
                i++;
            }
            return closest;
        }

        public int ThreeSumClosest_Own(int[] nums, int target)
        {
            int closest = 0;
            if (nums == null)
            {
                return closest;
            }
            Array.Sort(nums);
            for(int i=0; i<nums.Length-2;i++)
            {
                int j = i + 1;
                int k = nums.Length - 1;
                while(j<k)
                {
                    int sum = nums[i] + nums[j] + nums[k];
                    if (Math.Abs(target - sum) < Math.Abs(target - closest))
                    {
                        closest = sum;
                        if(closest == target)
                        {
                            return closest;
                        }
                    }
                    if (sum > target)
                    {
                        k--;
                    }
                    else
                    {
                        j++;
                    }

                }
            }
            return closest;
        }
    }
}
