using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet078_Subsets
    {
        IList<IList<int>> list = new List<IList<int>>();
        public IList<IList<int>> Subsets(int[] nums)
        {

            if (nums != null && nums.Length > 0)
            {
                int[] used = new int[nums.Length];
                fillList(nums, used, 0);
            }
            return list;
        }

        private void fillList(int[] nums, int[] used, int index)
        {
            if (index == nums.Length)
            {
                List<int> l = new List<int>();
                for (int i = 0; i < nums.Length; i++)
                {
                    if (used[i] == 1)
                    {
                        l.Add(nums[i]);
                    }
                }
                list.Add(l);
            }
            else
            {
                for (int i = 0; i < 2; i++)
                {
                    used[index] = i;
                    fillList(nums, used, index + 1);
                    used[index] = 0;
                }
            }
        }
    }
}
