using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet001_Two_Sum
    {
        public int[] TwoSum(int[] nums, int target)
        {
            if (nums == null)
            {
                throw new ArgumentNullException("Argument cannot be null!");
            }


            Dictionary<int, int> dict = new Dictionary<int, int>();

            dict.Add(nums[0], 0);
            for (int i = 1; i < nums.Length; i++)
            {
                if (dict.ContainsKey(target - nums[i]))
                {
                    return new int[] { dict[target - nums[i]], i };
                }
                else
                {
                    if (!dict.ContainsKey(nums[i]))
                    {
                        dict.Add(nums[i], i);
                    }
                }
            }

            return new int[] { -1, -1 };
        }

        public int[] TwoSum2(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        int[] res = new int[2];
                        res[0] = i;
                        res[1] = j;
                        return res;
                    }
                }
            }
            return null;
        }
    }

}
