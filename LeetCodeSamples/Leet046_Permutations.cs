using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet046_Permutations
    {
        public List<List<int>> permute(int[] nums)
        {
            List<List<int>> res = new List<List<int>>();
            //List<int> temp = new List<int>();
            dfs(res, nums, 0);
            return res;
        }
        private void dfs(List<List<int>> res, int[] nums, int j)
        {
            if (j == nums.Length)
            {
                List<int> temp = new List<int>();
                foreach (int num in nums)
                {
                    temp.Add(num);
                }
                res.Add(temp);
            }
            for (int i = j; i < nums.Length; i++)
            {
                swap(nums, i, j);
                dfs(res, nums, j + 1);
                swap(nums, i, j);
            }
        }
        private void swap(int[] nums, int m, int n)
        {
            int temp = nums[m];
            nums[m] = nums[n];
            nums[n] = temp;
        }


        public List<List<int>> permute2(int[] nums)
        {
            List<List<int>> res = new List<List<int>>();
            dfs2(res, new List<int>(), nums, new bool[nums.Length]);
            return res;
        }

        private void dfs2(List<List<int>> res, List<int> temp, int[] nums, bool[] used)
        {
            if (temp.Count == nums.Length)
            {
                res.Add(new List<int>(temp));
                return;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (!used[i])
                {
                    used[i] = true;
                    temp.Add(nums[i]);
                    dfs2(res, temp, nums, used);
                    temp.RemoveAt(temp.Count - 1);
                    used[i] = false;
                }
            }
        }


        public List<List<int>> permute3(int[] nums)
        {
            List<List<int>> res = new List<List<int>>();
            List<int> first = new List<int>();
            first.Add(nums[0]);
            res.Add(first);
            for (int i = 1; i < nums.Length; i++)
            {
                List<List<int>> newRes = new List<List<int>>();
                foreach (List<int> temp in res)
                {
                    int size = temp.Count + 1;
                    for (int j = 0; j < size; j++)
                    {
                        List<int> item = new List<int>(temp);
                        item.Insert(j, nums[i]);
                        newRes.Add(item);
                    }
                }
                res = newRes;
            }
            return res;
        }

        public List<List<int>> permute4(int[] nums)
        {
            List<List<int>> res = new List<List<int>>();
            if (nums.Length == 0 || nums == null)
                return res;
            List<int> list = new List<int>();
            list.Add(nums[0]); // Add the first element into the list;  
            res.Add(list);
            for (int i = 1; i < nums.Length; i++)
            {
                // Keep track of the size of current result;  
                int size = res.Count;
                for (int j = 0; j < size; j++)
                {
                    int size2 = res.ElementAt(0).Count;
                    for (int k = 0; k <= size2; k++)
                    {
                        List<int> temp = new List<int>(res.ElementAt(0));
                        temp.Insert(k, nums[i]);
                        res.Add(temp);
                    }
                    res.RemoveAt(0);
                }
            }
            return res;
        }


    }
    
}
