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


        public static IList<IList<int>> Subsets_Own(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return null;
            }
            IList<IList<int>> res = new List<IList<int>>();
            List<int> temp = new List<int>();
            dfs(nums, temp, 0, res);
            return res;

        }

        static void dfs(int[] nums, List<int> temp, int start, IList<IList<int>> res)
        {
            res.Add(new List<int>(temp));

            for (int i = start; i < nums.Length; i++)
            {
                temp.Add(nums[i]);
                dfs(nums, temp, i+1, res);
                temp.RemoveAt(temp.Count - 1);

            }
        }
    }
}
