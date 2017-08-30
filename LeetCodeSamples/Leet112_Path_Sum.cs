using LeetCodeSamples.DataStruct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSamples
{
    public class Leet112_Path_Sum
    {
        public static bool HasPathSum(TreeNode root, int sum)
        {
            if (root == null)
            {
                return false;
            }
            if (root.left == null && root.right == null)
            {
                return root.val == sum;
            }
            bool left = HasPathSum(root.left, sum - root.val);
            bool right = HasPathSum(root.right, sum - root.val);

            return left || right;
        }
    }
}
