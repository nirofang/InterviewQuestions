using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet015_3Sum
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> list = new List<IList<int>>();

            if (nums != null && nums.Length > 2)
            {
                Array.Sort(nums);
                int i = 0;
                while (i < nums.Length - 2)
                {
                    if (nums[i] > 0)
                    {
                        break;
                    }
                    int j = i + 1;
                    int k = nums.Length - 1;
                    while (j < k && nums[i] + nums[j] <= 0)
                    {
                        if (nums[i] + nums[j] + nums[k] == 0)
                        {
                            list.Add(new List<int>() { nums[i], nums[j], nums[k] });
                            while (j < k && nums[j + 1] == nums[j])
                            {
                                j++;
                            }
                            while (j < k && nums[k - 1] == nums[k])
                            {
                                k--;
                            }
                            j++;
                            k--;
                        }
                        else if (nums[i] + nums[j] + nums[k] > 0)
                        {
                            k--;
                        }
                        else
                        {
                            j++;
                        }
                    }
                    while (i < nums.Length - 2 && nums[i + 1] == nums[i])
                    {
                        i++;
                    }
                    i++;
                }
            }
            return list;
        }


        public IList<IList<int>> ThreeSum_Own(int[] nums)
        {
            IList<IList<int>> res = new List<IList<int>>();
            Array.Sort(nums);

            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }
                if (nums[i] > 0)
                {
                    break;
                }

                int j = i + 1;
                int k = nums.Length - 1;

                while (j < k)
                {
                    if (j > i + 1 && nums[j] == nums[j - 1])
                    {
                        j++;
                        continue;
                    }


                    if (nums[i] + nums[j] > 0)
                    {
                        break;
                    }

                    if (nums[i] + nums[j] + nums[k] < 0)
                    {
                        j++;
                    }
                    else if (nums[i] + nums[j] + nums[k] > 0)
                    {
                        k--;
                    }
                    else
                    {
                        List<int> tripples = new List<int>();
                        tripples.Add(nums[i]);
                        tripples.Add(nums[j]);
                        tripples.Add(nums[k]);
                        res.Add(tripples);
                        i++;
                        k--;
                    }
                }

            }
            return res;
        }
    }
}
