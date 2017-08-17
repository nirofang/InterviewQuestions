using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet090_Subsets_II
    {
        public IList<IList<int>> SubsetsWithDup(int[] nums)
        {
            IList<IList<int>> results = new List<IList<int>>();
            if (nums != null && nums.Length > 0)
            {
                Array.Sort(nums);
                int previous = 0;
                int length = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    length = results.Count;
                    if (i == 0 || nums[i] != nums[i - 1])
                    {
                        previous = 0;
                        results.Add(new List<int>() { nums[i] });
                    }
                    for (int j = previous; j < length; j++)
                    {
                        IList<int> list = results[j];
                        List<int> newList = list.Select(item =>item).ToList<int>();
                        newList.Add(nums[i]);
                        results.Add(newList);
                }
                    previous = length;
                }
                results.Add(new List<int>());
            }
            return results;
        }
    }
}
