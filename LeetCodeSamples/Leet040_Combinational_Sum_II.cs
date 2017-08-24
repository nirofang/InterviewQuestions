using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet040_Combinational_Sum_II
    {
        public List<List<int>> combinationalSum2(int[] A, int target)
        {
            List<List<int>> res = new List<List<int>>();
            if (A == null || A.Length == 0)
            {
                return res;
            }
            Array.Sort(A);
            helper(A, target, 0, new List<int>(), res);
            return res;

        }

        private void helper(int[] A, int target, int pos, List<int> comb, List<List<int>> res)
        {
            if (target == 0)
            {
                res.Add(new List<int>(comb));
                return;
            }
            for (int i = pos; i < A.Length; i++)
            {
                int newTar = target - A[i];
                if (newTar >= 0)
                {
                    //if (comb.Contains(A[i]))
                    //{
                    //    continue;
                    //}
                    
                    comb.Add(A[i]);
                    helper(A, newTar, i + 1, comb, res);
                    //comb.Remove(comb.Count - 1);
                    comb.RemoveAt(comb.Count - 1);
                }
                else
                {
                    break;
                }

                while (i < A.Length - 1 && A[i] == A[i + 1])
                {
                    i++;
                }
            }

        }
    }
}
