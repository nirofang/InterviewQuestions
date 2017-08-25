using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet046_Permutations_II
    {
        public List<List<int>> permuteUnique(int[] num)
        {
            List<List<int>> res = new List<List<int>>();
            if (num == null && num.Length == 0)
                return res;
            Array.Sort(num);
            helper(num, new bool[num.Length], new List<int>(), res);
            return res;
        }
        private void helper(int[] num, bool[] used, List<int> item, List<List<int>> res)
        {
            if (item.Count == num.Length)
            {
                res.Add(new List<int>(item));
                return;
            }
            for (int i = 0; i < num.Length; i++)
            {
                if (i > 0 && !used[i - 1] && num[i] == num[i - 1])
                {
                    continue;
                }
                if (!used[i])
                {
                    used[i] = true;
                    item.Add(num[i]);
                    helper(num, used, item, res);
                    item.RemoveAt(item.Count - 1);
                    used[i] = false;
                }
            }
        }
    }
}
