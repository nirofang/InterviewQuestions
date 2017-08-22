using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet018_4Sum
    {
        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            IList<IList<int>> list = new List<IList<int>>();
            if (nums != null && nums.Length > 3)
            {
                int i = 0;
                Array.Sort(nums);
                while (i < nums.Length - 3)
                {
                    int j = i + 1;

                    while (j < nums.Length - 2)
                    {
                        int k = j + 1;
                        int m = nums.Length - 1;
                        while (k < m)
                        {
                            int sum = nums[i] + nums[j] + nums[k] + nums[m];
                            if (sum == target)
                            {
                                list.Add(new List<int>() { nums[i], nums[j], nums[k], nums[m] });
                                while (k < m && nums[k] == nums[k + 1])
                                {
                                    k++;
                                }
                                while (k < m && nums[m - 1] == nums[m])
                                {
                                    m--;
                                }
                                k++;
                                m--;
                            }
                            else
                            {
                                if (sum < target)
                                {
                                    k++;
                                }
                                else
                                {
                                    m--;
                                }
                            }
                        }
                        while (j < m && nums[j + 1] == nums[j])
                        {
                            j++;
                        }
                        j++;
                    }
                    while (i < nums.Length - 3 && nums[i] == nums[i + 1])
                    {
                        i++;
                    }
                    i++;
                }
            }
            return list;
        }


        public IList<IList<int>> FourSum_Own(int[] nums, int target)
        {
            IList<IList<int>> res = new List<IList<int>>();
            if (nums == null || nums.Length < 4) return res;
            Array.Sort(nums);


            for (int i = 0; i < nums.Length - 3; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }
                for(int j = i +1; j<nums.Length -2; j++)
                {
                    if (j > i + 1&& nums[j] == nums[j-1])
                    {
                        continue;
                    }
                    int newTar = target - nums[i] - nums[j];
                    int l = j + 1;
                    int r = nums.Length - 1;
                    while (l < r)
                    {
                        if (l > j + 1 && nums[l] == nums[l - 1])
                        {
                            l++;
                            continue;
                        }
                        if (r < nums.Length - 1 && nums[r] == nums[r + 1])
                        {
                            r--;
                            continue;
                        }
                        int sum = nums[l] + nums[r];
                        if (sum < newTar) l++;
                        else if (sum > newTar) r--;
                        else
                        {
                            res.Add(new List<int> { nums[i], nums[j], nums[l], nums[r] });
                            l++;
                            r--;
                        }
                    }
                }
            }
            return res;
        }
    }
}
