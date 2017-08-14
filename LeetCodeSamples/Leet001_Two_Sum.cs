using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet001_Two_Sum
    {
        public int[] Two_Sum_dic_n(int[] nums, int target)
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

        public int[] Two_Sum_Self_n2(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[2] { i, j };
                    }
                }
            }
            return null;
        }

        public int[] Two_Sum_dic_n_Self(int[] nums, int target)
        {
            if (nums == null)
            {
                throw new ArgumentNullException("nums is null");
            }

            // Use one val in array to locate the index of another val by dic
            // key is value, val is index
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int match = target - nums[i];
                if (dic.ContainsKey(match))
                {
                    return new int[] { dic[match], i };
                }
                else
                {
                    dic[nums[i]] = i;
                }
            }
            return null;
        }
    }

}
