using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet136_Single_Number
    {
        public static int SingleNumber(int[] nums)
        {
            long res = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                res ^= nums[i];
            }
            if (res > int.MaxValue || res < int.MinValue)
            {
                return -1;
            }
            else
            {
                return (int)res;
            }
        }

        public static int SingleNumber2(int[] nums)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for(int i=0; i<nums.Length; i++)
            {
                int num = nums[i];
                if(dict.ContainsKey(num))
                {
                    dict[num]++;
                }
                else
                {
                    dict[num] = 1;
                }
            }
            for(int i = 0; i < nums.Length; i++)
            {
                if (dict[nums[i]]==1)
                {
                    return nums[i];
                }
            }
            return -1;
        }
    }
}
