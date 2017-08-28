using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet077_Combinations
    {
        static void combine_helper(int start, int num, int n, int k, List<int> temp, List<List<int>> result)
        {
            if (num == k)
            {
                List<int> copy = new List<int>(temp);
                result.Add(copy);
                
                return;
            }
            for (int i = start; i < n; i++)
            {
                temp.Add(i + 1);
                combine_helper(i + 1, num + 1, n, k, temp, result);
                temp.RemoveAt(temp.Count-1);
            }
        }
        public static List<List<int>> combine(int n, int k)
        {
            List<List<int>> result = new List<List<int>>();
            if (n == 0 || k == 0)
                return result;
            List<int> temp = new List<int>();
            combine_helper(0, 0, n, k, temp, result);
            return result;
        }
    }
}
